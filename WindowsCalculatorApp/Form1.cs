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

            foreach (Button currentButton in keyBoardGroupBox.Controls.OfType<Button>()) {
                byte parsedButtonValue;
                if (byte.TryParse(currentButton.Text, out parsedButtonValue)) {
                    currentButton.Click += new EventHandler(anyButtonClickHandler);
                }
            }

        }

        private void anyButtonClickHandler(object sender, EventArgs e) {
            byte pressedKeyNumber = byte.Parse(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.ShowNumber(pressedKeyNumber);
        }

        private void clearActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.ClearResultTextBox();
        }

        private void decimalDividerButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.AddDecimalDivider();
        }
    }
}
