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

            foreach (Button currentActionButton in operationsGroupBox.Controls.OfType<Button>()) {
                if (currentActionButton.Text != "POW")
                    currentActionButton.Click += new EventHandler(anyUnaryActionButtonClickHandler);
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
            CalculatorEngine.Action newAction = new CalculatorEngine.Action(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.Action.SetAction(newAction);
        }

        private void equalsActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.Action.PerformCalculation();
        }

        private void anyUnaryActionButtonClickHandler(object sender, EventArgs e) {
            CalculatorEngine.UnaryAction newAction = new CalculatorEngine.UnaryAction(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.UnaryAction.PerformUnaryCalculation(newAction);
        }

        private void powerActionButton_Click(object sender, EventArgs e) {
            CalculatorEngine.Action newAction = new CalculatorEngine.Action(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.Action.SetAction(newAction);
        }
    }
}
