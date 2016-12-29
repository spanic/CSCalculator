namespace WindowsCalculatorApp {
    partial class inputEqParametersForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputEqParametersForm));
            this.firstSummandTextBox = new System.Windows.Forms.TextBox();
            this.secondSummandTextBox = new System.Windows.Forms.TextBox();
            this.thirdSummandTextBox = new System.Windows.Forms.TextBox();
            this.equationResultTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.firstSummandLabel = new System.Windows.Forms.Label();
            this.secondSummandLabel = new System.Windows.Forms.Label();
            this.thirdSummandLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstSummandTextBox
            // 
            this.firstSummandTextBox.Location = new System.Drawing.Point(16, 45);
            this.firstSummandTextBox.Name = "firstSummandTextBox";
            this.firstSummandTextBox.Size = new System.Drawing.Size(33, 20);
            this.firstSummandTextBox.TabIndex = 0;
            this.firstSummandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstSummandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplierTextBox_KeyPress);
            // 
            // secondSummandTextBox
            // 
            this.secondSummandTextBox.Location = new System.Drawing.Point(81, 45);
            this.secondSummandTextBox.Name = "secondSummandTextBox";
            this.secondSummandTextBox.Size = new System.Drawing.Size(33, 20);
            this.secondSummandTextBox.TabIndex = 1;
            this.secondSummandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondSummandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplierTextBox_KeyPress);
            // 
            // thirdSummandTextBox
            // 
            this.thirdSummandTextBox.Location = new System.Drawing.Point(143, 45);
            this.thirdSummandTextBox.Name = "thirdSummandTextBox";
            this.thirdSummandTextBox.Size = new System.Drawing.Size(33, 20);
            this.thirdSummandTextBox.TabIndex = 2;
            this.thirdSummandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thirdSummandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplierTextBox_KeyPress);
            // 
            // equationResultTextBox
            // 
            this.equationResultTextBox.Location = new System.Drawing.Point(199, 45);
            this.equationResultTextBox.Name = "equationResultTextBox";
            this.equationResultTextBox.Size = new System.Drawing.Size(33, 20);
            this.equationResultTextBox.TabIndex = 3;
            this.equationResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equationResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplierTextBox_KeyPress);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(255, 13);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Введите коэффициенты квадратного уравнения:";
            // 
            // firstSummandLabel
            // 
            this.firstSummandLabel.AutoSize = true;
            this.firstSummandLabel.Location = new System.Drawing.Point(55, 48);
            this.firstSummandLabel.Name = "firstSummandLabel";
            this.firstSummandLabel.Size = new System.Drawing.Size(24, 13);
            this.firstSummandLabel.TabIndex = 5;
            this.firstSummandLabel.Text = "x² +";
            // 
            // secondSummandLabel
            // 
            this.secondSummandLabel.AutoSize = true;
            this.secondSummandLabel.Location = new System.Drawing.Point(120, 48);
            this.secondSummandLabel.Name = "secondSummandLabel";
            this.secondSummandLabel.Size = new System.Drawing.Size(21, 13);
            this.secondSummandLabel.TabIndex = 6;
            this.secondSummandLabel.Text = "x +";
            // 
            // thirdSummandLabel
            // 
            this.thirdSummandLabel.AutoSize = true;
            this.thirdSummandLabel.Location = new System.Drawing.Point(182, 48);
            this.thirdSummandLabel.Name = "thirdSummandLabel";
            this.thirdSummandLabel.Size = new System.Drawing.Size(13, 13);
            this.thirdSummandLabel.TabIndex = 7;
            this.thirdSummandLabel.Text = "=";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(369, 43);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(288, 43);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "ОК";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // inputEqParametersForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 77);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.thirdSummandLabel);
            this.Controls.Add(this.secondSummandLabel);
            this.Controls.Add(this.firstSummandLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.equationResultTextBox);
            this.Controls.Add(this.thirdSummandTextBox);
            this.Controls.Add(this.secondSummandTextBox);
            this.Controls.Add(this.firstSummandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputEqParametersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quaratic Equation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label firstSummandLabel;
        private System.Windows.Forms.Label secondSummandLabel;
        private System.Windows.Forms.Label thirdSummandLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        public System.Windows.Forms.TextBox firstSummandTextBox;
        public System.Windows.Forms.TextBox secondSummandTextBox;
        public System.Windows.Forms.TextBox thirdSummandTextBox;
        public System.Windows.Forms.TextBox equationResultTextBox;
    }
}