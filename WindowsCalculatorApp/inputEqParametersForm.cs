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
    public partial class inputEqParametersForm : Form {
        public inputEqParametersForm() {
            InitializeComponent();
        }

        private void multiplierTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar != 22) /* Ctrl + V */
                e.Handled = !Char.IsDigit(e.KeyChar) /* Not digit */ 
                    && (
                        e.KeyChar != ',' /* Not a comma */ || (
                            ((TextBox)sender).Text.Contains(",") /* Comma already exists */
                            && !((TextBox)sender).SelectedText.Contains(",") /* Comma isn't selected */
                        )
                    ) && e.KeyChar != (char)Keys.Back /* Not a backspace */
                    && (
                        e.KeyChar != '-' /* Not a dash */ 
                        || ((TextBox)sender).SelectionStart != 0 /* Not at the start position */
                        || (
                            ((TextBox)sender).Text.Contains("-") /* Dash already exists */
                            && !((TextBox)sender).SelectedText.Contains("-") /* Dash isn't selected */
                        )
                    );
            else {
                double d;
                e.Handled = !double.TryParse(Clipboard.GetText(), out d) /* Cannot be parsed to double */
                    /* Prevents from pasting any n < 0 in the middle of the existing number below zero */
                    || (d < 0 && ( 
                        ((TextBox)sender).SelectionStart != 0 
                        || ((TextBox)sender).Text.Contains("-") 
                        && !((TextBox)sender).SelectedText.Contains("-")
                    )) 
                    /* Prevents from pasting any fractional number if it already exists in the field */
                    || (
                        (d - (int)d) != 0 && ((TextBox)sender).Text.Contains(",") 
                        && !((TextBox)sender).SelectedText.Contains(",")
                    );
            }
        }

    }
}
