using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsCalculatorApp {

    public enum States : byte {
        Initial, /* 0, while entering the first number */
        Proceeding, /* 1, after selecting any action */
        Final /* 2, after clicking "=" */
    }

    public abstract class CalculatorEngine {

        public class Action {

            private string alias;

            public Action(string alias) {
                this.alias = alias;
            }

            protected bool Equals(Action obj) {
                if (obj == null) return false;
                return this.alias == obj.alias;
            }

        }

        public sealed class UnaryAction : Action {

            public UnaryAction(string alias) : base(alias) {}

            private static readonly UnaryAction Revert = new UnaryAction("1 / X");
            private static readonly UnaryAction SQR = new UnaryAction("SQR");
            private static readonly UnaryAction SQRT = new UnaryAction("SQRT");
            private static readonly UnaryAction CURT = new UnaryAction("CURT");

            public static string PerformUnaryCalculation(UnaryAction actionInstance) {
                resultTextBoxData = resultTextBoxData.TrimEnd(DECIMAL_DIVIDER);
                currentState = States.Final;
                firstOperand = Convert.ToDouble(resultTextBoxData);
                action = actionInstance;
                if (Revert.Equals(action))
                    totalResult = 1 / firstOperand;
                else if (SQR.Equals(action))
                    totalResult = Math.Pow(firstOperand, 2);
                else if (SQRT.Equals(action)) {
                    if (firstOperand < 0)
                        ShowError("Квадратный корень нельзя извлечь из отрицательного числа");
                    else
                        totalResult = Math.Sqrt(firstOperand);
                } else if (CURT.Equals(action))
                    totalResult = Math.Sign(firstOperand) * Math.Pow(
                        Math.Abs(firstOperand), (1.0 / 3.0));
                return resultTextBoxData = totalResult.ToString();
            }

        }

        public sealed class BinaryAction : Action {

            public BinaryAction(string alias) : base(alias) {}

            private static readonly BinaryAction Add = new BinaryAction("+");
            private static readonly BinaryAction Subtract = new BinaryAction("–");
            private static readonly BinaryAction Multiply = new BinaryAction("×");
            private static readonly BinaryAction Divide = new BinaryAction("/");
            private static readonly BinaryAction Power = new BinaryAction("POW");

            public static string SetAction(Action actionToProceed) {
                if (currentState == States.Proceeding || currentState == States.Final)
                    PerformCalculation();
                else
                    resultTextBoxData = resultTextBoxData.TrimEnd(DECIMAL_DIVIDER);
                firstOperand = Convert.ToDouble(resultTextBoxData);
                action = actionToProceed;
                currentState = States.Proceeding;
                return resultTextBoxData;
            }

            public static string PerformCalculation() {
                resultTextBoxData = resultTextBoxData.TrimEnd(DECIMAL_DIVIDER);
                if (currentState == States.Initial || currentState == States.Final) {
                    currentState = States.Final;
                    return resultTextBoxData;
                }
                secondOperand = Convert.ToDouble(resultTextBoxData);
                currentState = States.Final;
                if (Add.Equals(action))
                    totalResult = firstOperand + secondOperand;
                else if (Subtract.Equals(action))
                    totalResult = firstOperand - secondOperand;
                else if (Multiply.Equals(action))
                    totalResult = firstOperand * secondOperand;
                else if (Divide.Equals(action))
                    totalResult = firstOperand / secondOperand;
                else if (Power.Equals(action))
                    totalResult = Math.Pow(firstOperand, secondOperand);
                return resultTextBoxData = totalResult.ToString();
            }

        }

        public static States currentState = States.Initial;
        private static string resultTextBoxData = EMPTY_STRING_VALUE;
        private static string factorialCalculationTextBoxData = EMPTY_STRING_VALUE;
        private static double firstOperand;
        private static Action action;
        private static double secondOperand;
        private static double totalResult;
        private static ulong factorialCalculationResult;
        private const string EMPTY_STRING_VALUE = "";
        private const string ZERO_STRING_VALUE = "0";
        private const char DECIMAL_DIVIDER = ',';

        public static string ShowNumber(byte pressedKeyNumber) {
            if (currentState == States.Final) {
                ResetCurrentState();
            }
            if (resultTextBoxData == ZERO_STRING_VALUE || resultTextBoxData.Length == 0 
                || firstOperand.ToString() == resultTextBoxData) {
                return resultTextBoxData = pressedKeyNumber.ToString();
            } else
                return resultTextBoxData = string.Concat(resultTextBoxData, pressedKeyNumber.ToString());
        }
        
        public static string ClearResultTextBox() {
            return resultTextBoxData = ZERO_STRING_VALUE;
        }

        private static void NullifyEverything() {
            currentState = States.Initial;
            firstOperand = 0;
            secondOperand = 0;
            action = null;
            totalResult = 0;
            factorialCalculationResult = 0;
        }

        public static string ResetCurrentState() {
            NullifyEverything();
            ClearResultTextBox();
            return ZERO_STRING_VALUE;
        }

        public static string AddDecimalDivider() {
            if (!resultTextBoxData.Contains(DECIMAL_DIVIDER)) {
                resultTextBoxData = string.Concat(resultTextBoxData, DECIMAL_DIVIDER);
            }
            if (currentState == States.Final) currentState = States.Initial;
            return resultTextBoxData;
        }

        private delegate ulong AsyncFactorial(uint n);

        public static string ReturnFactorial() {
            uint n;
            if (uint.TryParse(resultTextBoxData, out n)) {
                AsyncFactorial asyncFactorialCalculation = new AsyncFactorial(CalculateFactorial);
                AsyncCallback callback = new AsyncCallback(FactorialCallback);
                asyncFactorialCalculation.BeginInvoke(n, callback, asyncFactorialCalculation);
            } else {
                ShowError("Факториал нельзя вычислить из ненатурального числа");
            }
            currentState = States.Final;
            return factorialCalculationTextBoxData;
        }

        private static ulong CalculateFactorial(uint n) {
            ulong result;
            if (n == 1) return 1;
            result = CalculateFactorial(n - 1) * n;
            System.Threading.Thread.Sleep(500); /* Long operation imitation */
            return result;
        }

        private static void FactorialCallback(IAsyncResult operationResult) {
            AsyncFactorial factiorialDelegate = (AsyncFactorial)operationResult.AsyncState;
            factorialCalculationResult = factiorialDelegate.EndInvoke(operationResult);
            factorialCalculationTextBoxData = factorialCalculationResult.ToString();
            ShowInfo("Значение факториала введенного числа: " + factorialCalculationTextBoxData);
        }

        public static string SolveQuadraticEquation(double firstParameter, double secondParameter,
            double thirdParameter, double fourthParameter) {
            double discriminant = Math.Pow(secondParameter, 2) - 4 * firstParameter * (thirdParameter - fourthParameter);
            if (discriminant < 0) return "Корни — комплексные числа";
            else if (discriminant == 0)
                return "Корень: " + (-1 * secondParameter / (2 * firstParameter));
            else
                return "К. №1: " + Math.Round(
                    ((-1 * secondParameter + Math.Sqrt(discriminant)) / 2 * firstParameter),
                    3, MidpointRounding.AwayFromZero) + "; К. №2: " + Math.Round((
                    (-1 * secondParameter - Math.Sqrt(discriminant)) / 2 * firstParameter),
                    3, MidpointRounding.AwayFromZero);
        }

        private static void ShowError(string errorText) {
            MessageBox.Show(
                    errorText,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
        }

        private static void ShowInfo(string informationText) {
            MessageBox.Show(
                informationText,
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
        }

    }
}
