using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            private static readonly Action Add = new Action("+");
            private static readonly Action Subtract = new Action("–");
            private static readonly Action Multiply = new Action("×");
            private static readonly Action Divide = new Action("/");
            private static readonly Action Power = new Action("POW");

            protected bool Equals(Action obj) {
                if (obj == null) return false;
                return this.alias == obj.alias;
            }

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
                    result = firstOperand + secondOperand;
                else if (Subtract.Equals(action))
                    result = firstOperand - secondOperand;
                else if (Multiply.Equals(action))
                    result = firstOperand * secondOperand;
                else if (Divide.Equals(action))
                    result = firstOperand / secondOperand;
                else if (Power.Equals(action))
                    result = Math.Pow(firstOperand, secondOperand);
                return resultTextBoxData = result.ToString();
            }

        }

        public sealed class UnaryAction : Action {

            public UnaryAction(string alias) : base(alias) {}

            private static readonly UnaryAction Revert = new UnaryAction("1 / X");
            private static readonly UnaryAction SQR = new UnaryAction("SQR");
            private static readonly UnaryAction SQRT = new UnaryAction("SQRT");

            public static string PerformUnaryCalculation(UnaryAction actionInstance) {
                resultTextBoxData = resultTextBoxData.TrimEnd(DECIMAL_DIVIDER);
                currentState = States.Final;
                firstOperand = Convert.ToDouble(resultTextBoxData);
                action = actionInstance;
                if (Revert.Equals(action))
                    result = 1 / firstOperand;
                else if (SQR.Equals(action))
                    result = Math.Pow(firstOperand, 2);
                else if (SQRT.Equals(action))
                    result = Math.Sqrt(firstOperand);
                return resultTextBoxData = result.ToString();
            }

        }

        public static States currentState = States.Initial;
        private static string resultTextBoxData = EMPTY_STRING_VALUE;
        private static double firstOperand;
        private static Action action;
        private static double secondOperand;
        private static double result;
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
            result = 0;
        }

        public static string ResetCurrentState() {
            NullifyEverything();
            return ClearResultTextBox();
        }

        public static string AddDecimalDivider() {
            if (!resultTextBoxData.Contains(DECIMAL_DIVIDER)) {
                resultTextBoxData = string.Concat(resultTextBoxData, DECIMAL_DIVIDER);
            }
            return resultTextBoxData;
        }

    }
}
