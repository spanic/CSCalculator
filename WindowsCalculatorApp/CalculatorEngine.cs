using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsCalculatorApp {

    public enum Actions : byte {
        Add, /* 0 */
        Subtract, /* 1 */
        Multiply, /* 2 */
        Divide /* 3 */
    }

    public enum States : byte {
        Initial, /* 0, while entering the first number */
        Proceeding, /* 1, after selecting any action */
        Final /* 2, after clicking "=" */
    }

    public abstract class CalculatorEngine {

        public static States currentState = States.Initial;
        private static string resultTextBoxData = EMPTY_STRING_VALUE;
        private static double firstOperand;
        private static Actions action;
        private static double secondOperand;
        private static double result;
        private const string EMPTY_STRING_VALUE = "";
        private const string ZERO_STRING_VALUE = "0";
        private const char DECIMAL_DIVIDER = ',';

        public static string ShowNumber(byte pressedKeyNumber) {
            if (currentState == States.Final) {
                ResetCurrentState();
            }
            if (resultTextBoxData == ZERO_STRING_VALUE
                    || resultTextBoxData.Length == 0) {
                return resultTextBoxData = pressedKeyNumber.ToString();
            } else
                return resultTextBoxData = string.Concat(resultTextBoxData, pressedKeyNumber.ToString());
        }
        
        public static string ClearResultTextBox() {
            return resultTextBoxData = ZERO_STRING_VALUE;
        }

        private static void ResetCurrentState() {
            currentState = States.Initial;
            ClearResultTextBox();
        }

        public static string AddDecimalDivider() {
            if (!resultTextBoxData.Contains(DECIMAL_DIVIDER))
                resultTextBoxData = string.Concat(resultTextBoxData, DECIMAL_DIVIDER);
            currentState = States.Initial;
            return resultTextBoxData;
        }

        public static string SetAction(Actions actionToProceed) {
            resultTextBoxData = resultTextBoxData.TrimEnd(DECIMAL_DIVIDER);
            if (currentState == States.Proceeding) {
                PerformCalculation();
            }
            firstOperand = Convert.ToDouble(resultTextBoxData);
            action = actionToProceed;
            currentState = States.Proceeding;
            return ClearResultTextBox();
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
            }
            return resultTextBoxData = result.ToString();
        }

    }
}
