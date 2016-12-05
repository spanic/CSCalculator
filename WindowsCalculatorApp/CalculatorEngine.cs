using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsCalculatorApp {

    public enum Actions : byte {
        Add, /* 0 */
        Subtract, /* 1 */
        Multiply, /* 2 */
        Divide, /* 3 */
        Power /* 4 */
    }

    public enum States : byte {
        Initial, /* 0, while entering the first number */
        Proceeding, /* 1, after selecting any action */
        Final /* 2, after clicking "=" */
    }

    public abstract class CalculatorEngine {

        /* public class BinaryAcion {

            public string symbol {
                get { return this.symbol; }
                private set { this.symbol = symbol; }
            }

            protected BinaryAcion(string symbol) {
                this.symbol = symbol;
            }

            public static readonly BinaryAcion Add = new BinaryAcion("+");
            BinaryAcion Subtract = new BinaryAcion("–");
            BinaryAcion Multiply = new BinaryAcion("×");
            BinaryAcion Divide = new BinaryAcion("/");
            BinaryAcion Power = new BinaryAcion("POW");
        } */

        public static States currentState = States.Initial;
        private static string resultTextBoxData = EMPTY_STRING_VALUE;
        private static double firstOperand;
        private static Actions? action;
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

        public static string SetAction(Actions actionToProceed) {
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
            switch (action) {
                case Actions.Add:
                    result = firstOperand + secondOperand;
                    break;
                case Actions.Subtract:
                    result = firstOperand - secondOperand;
                    break;
                case Actions.Multiply:
                    result = firstOperand * secondOperand;
                    break;
                case Actions.Divide:
                    result = firstOperand / secondOperand;
                    break;
                case Actions.Power:
                    result = Math.Pow(firstOperand, secondOperand);
                    break;
            }
            return resultTextBoxData = result.ToString();
        }

        public static string PerformSingleOperandCalculation() {

            return resultTextBoxData;
        }

    }
}
