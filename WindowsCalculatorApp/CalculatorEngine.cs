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

    public class CalculatorEngine {

        private static string resultTextBoxData = "";
        private const string ZERO_STRING_VALUE = "0";
        private const string DECIMAL_DIVIDER = ".";

        public static string ShowNumber(byte pressedKeyNumber) {
            if (resultTextBoxData == ZERO_STRING_VALUE || resultTextBoxData.Length == 0)
                return resultTextBoxData = pressedKeyNumber.ToString();
            else
                return resultTextBoxData = string.Concat(resultTextBoxData, pressedKeyNumber.ToString());
        }
        
        public static string ClearResultTextBox() {
            return resultTextBoxData = ZERO_STRING_VALUE;
        }

        public static string AddDecimalDivider() {
            if (!resultTextBoxData.Contains(DECIMAL_DIVIDER))
                resultTextBoxData = string.Concat(resultTextBoxData, DECIMAL_DIVIDER);
            return resultTextBoxData;
        }

    }
}
