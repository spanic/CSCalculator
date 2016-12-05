using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculatorApp {

    public partial class BaseForm : Form {

        private static Dictionary<char, Actions> actionSymbolsList = new Dictionary<char, Actions>() {
            ['+'] = Actions.Add,
            ['–'] = Actions.Subtract,
            ['×'] = Actions.Multiply,
            ['/'] = Actions.Divide
        };

        public string resultTextBoxString {
            get { return resultTextBox.Text; }
            set { resultTextBox.Text = value; }
        }

        public BaseForm() {

            InitializeComponent();

            resultTextBoxString = CalculatorEngine.ShowNumber(0);

            foreach (Button currentNumberButton in keyBoardGroupBox.Controls.OfType<Button>()) {
                byte parsedButtonValue;
                if (byte.TryParse(currentNumberButton.Text, out parsedButtonValue)) {
                    currentNumberButton.Click += new EventHandler(anyNumberButtonClickHandler);
                }
            }

            foreach (Button currentActionButton in actionsGroupBox.Controls.OfType<Button>()) {
                if (currentActionButton.Text != "=")
                    currentActionButton.Click += new EventHandler(anyActionButtonClickHandler);
            }

        }

        private void anyNumberButtonClickHandler(object sender, EventArgs e) {
            byte pressedKeyNumber = byte.Parse(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.ShowNumber(pressedKeyNumber);
        }

        private void clearActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.ResetCurrentState();
        }

        private void decimalDividerButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.AddDecimalDivider();
        }

        private void anyActionButtonClickHandler(object sender, EventArgs e) {
            char pressedKeyCharacter = char.Parse(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.SetAction(actionSymbolsList[pressedKeyCharacter]);
        }

        private void equalsActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.PerformCalculation();
        }

        private void powerActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.SetAction(Actions.Power);
        }

        /* private void reverseActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.SetAction();
        } */
    }
}
