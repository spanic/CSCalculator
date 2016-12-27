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

        private enum Layouts : byte {
            Standart,
            Engineering
        }

        private Layouts currentLayout;

        public string resultTextBoxString {
            get { return resultTextBox.Text; }
            set { resultTextBox.Text = value; }
        }

        public BaseForm() {

            InitializeComponent();

            applyLayout(Layouts.Engineering);

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

        private void applyLayout(Layouts newlLayout) {

            currentLayout = newlLayout;

            if (currentLayout == Layouts.Engineering) {

                this.Height = 508;

                engineeringGroupBox.Visible = true;
                
                /* Using method above instead of direct Contlols creation
                
                // GroupBox
                GroupBox engineeringGroupBox = new GroupBox();
                engineeringGroupBox.Location = new Point(12, 117);
                engineeringGroupBox.Size = new Size(374, 88);
                engineeringGroupBox.Text = "Дополнительные команды";
                this.Controls.Add(engineeringGroupBox);

                // Factorial Button
                Button factorialActionButton = new Button();
                factorialActionButton.Location = new Point(6, 21);
                factorialActionButton.Size = new Size(86, 30);
                factorialActionButton.Text = "FACT";
                operationsToolTip.SetToolTip(factorialActionButton, "Вычисление факториала");
                engineeringGroupBox.Controls.Add(factorialActionButton);

                // Cube Root Button
                Button cubeRootActionButton = new Button();
                engineeringGroupBox.Controls.Add(cubeRootActionButton);
                cubeRootActionButton.Location = new Point(98, 21);
                cubeRootActionButton.Size = new Size(86, 30);
                cubeRootActionButton.Text = "CURT";
                operationsToolTip.SetToolTip(cubeRootActionButton, 
                    "Вычисление кубического корня");

                // Solve Quadratic Equation Button
                Button solveEquationActionButton = new Button();
                engineeringGroupBox.Controls.Add(solveEquationActionButton);
                solveEquationActionButton.Location = new Point(190, 21);
                solveEquationActionButton.Size = new Size(178, 30);
                solveEquationActionButton.Text = "Quadratic equation";
                operationsToolTip.SetToolTip(solveEquationActionButton,
                    "Ввод и нахождение корней квадратного уравнения");

                // Factorial Result TextBox
                TextBox factorialResultTextBox = new TextBox();
                engineeringGroupBox.Controls.Add(factorialResultTextBox);
                factorialResultTextBox.Location = new Point(7, 58);
                factorialResultTextBox.Size = new Size(177, 22);
                factorialResultTextBox.ReadOnly = true;
                factorialResultTextBox.TextAlign = HorizontalAlignment.Right;

                // Equation Result TextBox
                TextBox equationResultTextBox = new TextBox();
                engineeringGroupBox.Controls.Add(equationResultTextBox);
                equationResultTextBox.Location = new Point(191, 58);
                equationResultTextBox.Size = new Size(177, 22);
                equationResultTextBox.ReadOnly = true; */

                changeViewMenuItem.Checked = true;

            } else if (currentLayout == Layouts.Standart) {

                this.Height = 411;
                engineeringGroupBox.Visible = false;
                changeViewMenuItem.Checked = false;

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
            resultTextBoxString = CalculatorEngine.BinaryAction.SetAction(newAction);
        }

        private void equalsActionButton_Click(object sender, EventArgs e) {
            resultTextBoxString = CalculatorEngine.BinaryAction.PerformCalculation();
        }

        private void anyUnaryActionButtonClickHandler(object sender, EventArgs e) {
            CalculatorEngine.UnaryAction newAction = new CalculatorEngine.UnaryAction(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.UnaryAction.PerformUnaryCalculation(newAction);
        }

        private void powerActionButton_Click(object sender, EventArgs e) {
            CalculatorEngine.Action newAction = new CalculatorEngine.Action(((Button)sender).Text);
            resultTextBoxString = CalculatorEngine.BinaryAction.SetAction(newAction);
        }

        private void changeViewMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (changeViewMenuItem.Checked == true) {
                applyLayout(Layouts.Engineering);
            } else {
                applyLayout(Layouts.Standart);
            }
        }
    }
}
