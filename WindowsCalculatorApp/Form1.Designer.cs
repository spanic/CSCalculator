namespace WindowsCalculatorApp {
    partial class BaseForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ActionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdvancedViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            this.powerActionButton = new System.Windows.Forms.Button();
            this.sqrtActionButton = new System.Windows.Forms.Button();
            this.reverseActionButton = new System.Windows.Forms.Button();
            this.sqrActionButton = new System.Windows.Forms.Button();
            this.plusActionButton = new System.Windows.Forms.Button();
            this.subtractActionButton = new System.Windows.Forms.Button();
            this.divideActionButton = new System.Windows.Forms.Button();
            this.multiplyActionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equalsActionButton = new System.Windows.Forms.Button();
            this.sevenNumButton = new System.Windows.Forms.Button();
            this.eightNumButton = new System.Windows.Forms.Button();
            this.nineNumButton = new System.Windows.Forms.Button();
            this.sixNumButton = new System.Windows.Forms.Button();
            this.fiveNumButton = new System.Windows.Forms.Button();
            this.fourNumButton = new System.Windows.Forms.Button();
            this.threeNumButton = new System.Windows.Forms.Button();
            this.twoNumButton = new System.Windows.Forms.Button();
            this.oneNumButton = new System.Windows.Forms.Button();
            this.zeroNumButton = new System.Windows.Forms.Button();
            this.clearActionButton = new System.Windows.Forms.Button();
            this.TopMenuStrip.SuspendLayout();
            this.operationsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionsMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(398, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // ActionsMenuItem
            // 
            this.ActionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeViewMenuItem,
            this.ExitMenuItem});
            this.ActionsMenuItem.Name = "ActionsMenuItem";
            this.ActionsMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ActionsMenuItem.Text = "Команды";
            // 
            // ChangeViewMenuItem
            // 
            this.ChangeViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultViewMenuItem,
            this.AdvancedViewMenuItem});
            this.ChangeViewMenuItem.Name = "ChangeViewMenuItem";
            this.ChangeViewMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChangeViewMenuItem.Text = "Сменить вид";
            // 
            // DefaultViewMenuItem
            // 
            this.DefaultViewMenuItem.Name = "DefaultViewMenuItem";
            this.DefaultViewMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DefaultViewMenuItem.Text = "Обычный";
            // 
            // AdvancedViewMenuItem
            // 
            this.AdvancedViewMenuItem.Name = "AdvancedViewMenuItem";
            this.AdvancedViewMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AdvancedViewMenuItem.Text = "Инженерный";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 27);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(374, 22);
            this.ResultTextBox.TabIndex = 1;
            // 
            // operationsGroupBox
            // 
            this.operationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsGroupBox.Controls.Add(this.sqrActionButton);
            this.operationsGroupBox.Controls.Add(this.sqrtActionButton);
            this.operationsGroupBox.Controls.Add(this.powerActionButton);
            this.operationsGroupBox.Controls.Add(this.reverseActionButton);
            this.operationsGroupBox.Location = new System.Drawing.Point(12, 54);
            this.operationsGroupBox.Name = "operationsGroupBox";
            this.operationsGroupBox.Size = new System.Drawing.Size(374, 56);
            this.operationsGroupBox.TabIndex = 2;
            this.operationsGroupBox.TabStop = false;
            this.operationsGroupBox.Text = "Базовые команды";
            // 
            // powerActionButton
            // 
            this.powerActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerActionButton.Location = new System.Drawing.Point(6, 19);
            this.powerActionButton.Name = "powerActionButton";
            this.powerActionButton.Size = new System.Drawing.Size(86, 30);
            this.powerActionButton.TabIndex = 0;
            this.powerActionButton.Text = "POW";
            this.powerActionButton.UseVisualStyleBackColor = true;
            // 
            // sqrtActionButton
            // 
            this.sqrtActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrtActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtActionButton.Location = new System.Drawing.Point(98, 19);
            this.sqrtActionButton.Name = "sqrtActionButton";
            this.sqrtActionButton.Size = new System.Drawing.Size(86, 30);
            this.sqrtActionButton.TabIndex = 1;
            this.sqrtActionButton.Text = "SQRT";
            this.sqrtActionButton.UseVisualStyleBackColor = true;
            // 
            // reverseActionButton
            // 
            this.reverseActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reverseActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverseActionButton.Location = new System.Drawing.Point(190, 19);
            this.reverseActionButton.Name = "reverseActionButton";
            this.reverseActionButton.Size = new System.Drawing.Size(86, 30);
            this.reverseActionButton.TabIndex = 2;
            this.reverseActionButton.Text = "1 / X";
            this.reverseActionButton.UseVisualStyleBackColor = true;
            // 
            // sqrActionButton
            // 
            this.sqrActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrActionButton.Location = new System.Drawing.Point(282, 19);
            this.sqrActionButton.Name = "sqrActionButton";
            this.sqrActionButton.Size = new System.Drawing.Size(86, 30);
            this.sqrActionButton.TabIndex = 3;
            this.sqrActionButton.Text = "SQR";
            this.sqrActionButton.UseVisualStyleBackColor = true;
            // 
            // plusActionButton
            // 
            this.plusActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusActionButton.Location = new System.Drawing.Point(6, 19);
            this.plusActionButton.Name = "plusActionButton";
            this.plusActionButton.Size = new System.Drawing.Size(73, 30);
            this.plusActionButton.TabIndex = 4;
            this.plusActionButton.Text = "+";
            this.plusActionButton.UseVisualStyleBackColor = true;
            // 
            // subtractActionButton
            // 
            this.subtractActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractActionButton.Location = new System.Drawing.Point(6, 55);
            this.subtractActionButton.Name = "subtractActionButton";
            this.subtractActionButton.Size = new System.Drawing.Size(73, 30);
            this.subtractActionButton.TabIndex = 5;
            this.subtractActionButton.Text = "–";
            this.subtractActionButton.UseVisualStyleBackColor = true;
            // 
            // divideActionButton
            // 
            this.divideActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divideActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideActionButton.Location = new System.Drawing.Point(6, 127);
            this.divideActionButton.Name = "divideActionButton";
            this.divideActionButton.Size = new System.Drawing.Size(73, 30);
            this.divideActionButton.TabIndex = 6;
            this.divideActionButton.Text = "/";
            this.divideActionButton.UseVisualStyleBackColor = true;
            // 
            // multiplyActionButton
            // 
            this.multiplyActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplyActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyActionButton.Location = new System.Drawing.Point(6, 91);
            this.multiplyActionButton.Name = "multiplyActionButton";
            this.multiplyActionButton.Size = new System.Drawing.Size(73, 30);
            this.multiplyActionButton.TabIndex = 7;
            this.multiplyActionButton.Text = "×";
            this.multiplyActionButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equalsActionButton);
            this.groupBox1.Controls.Add(this.plusActionButton);
            this.groupBox1.Controls.Add(this.divideActionButton);
            this.groupBox1.Controls.Add(this.subtractActionButton);
            this.groupBox1.Controls.Add(this.multiplyActionButton);
            this.groupBox1.Location = new System.Drawing.Point(301, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(85, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearActionButton);
            this.groupBox2.Controls.Add(this.zeroNumButton);
            this.groupBox2.Controls.Add(this.sixNumButton);
            this.groupBox2.Controls.Add(this.fiveNumButton);
            this.groupBox2.Controls.Add(this.oneNumButton);
            this.groupBox2.Controls.Add(this.fourNumButton);
            this.groupBox2.Controls.Add(this.threeNumButton);
            this.groupBox2.Controls.Add(this.twoNumButton);
            this.groupBox2.Controls.Add(this.nineNumButton);
            this.groupBox2.Controls.Add(this.eightNumButton);
            this.groupBox2.Controls.Add(this.sevenNumButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 246);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клавиатура";
            // 
            // equalsActionButton
            // 
            this.equalsActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalsActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsActionButton.Location = new System.Drawing.Point(6, 164);
            this.equalsActionButton.Name = "equalsActionButton";
            this.equalsActionButton.Size = new System.Drawing.Size(75, 73);
            this.equalsActionButton.TabIndex = 8;
            this.equalsActionButton.Text = "=";
            this.equalsActionButton.UseVisualStyleBackColor = true;
            // 
            // sevenNumButton
            // 
            this.sevenNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sevenNumButton.Location = new System.Drawing.Point(7, 19);
            this.sevenNumButton.Name = "sevenNumButton";
            this.sevenNumButton.Size = new System.Drawing.Size(86, 50);
            this.sevenNumButton.TabIndex = 0;
            this.sevenNumButton.Text = "7";
            this.sevenNumButton.UseVisualStyleBackColor = true;
            // 
            // eightNumButton
            // 
            this.eightNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eightNumButton.Location = new System.Drawing.Point(99, 19);
            this.eightNumButton.Name = "eightNumButton";
            this.eightNumButton.Size = new System.Drawing.Size(86, 50);
            this.eightNumButton.TabIndex = 1;
            this.eightNumButton.Text = "8";
            this.eightNumButton.UseVisualStyleBackColor = true;
            // 
            // nineNumButton
            // 
            this.nineNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nineNumButton.Location = new System.Drawing.Point(191, 19);
            this.nineNumButton.Name = "nineNumButton";
            this.nineNumButton.Size = new System.Drawing.Size(86, 50);
            this.nineNumButton.TabIndex = 2;
            this.nineNumButton.Text = "9";
            this.nineNumButton.UseVisualStyleBackColor = true;
            // 
            // sixNumButton
            // 
            this.sixNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sixNumButton.Location = new System.Drawing.Point(191, 75);
            this.sixNumButton.Name = "sixNumButton";
            this.sixNumButton.Size = new System.Drawing.Size(86, 50);
            this.sixNumButton.TabIndex = 5;
            this.sixNumButton.Text = "6";
            this.sixNumButton.UseVisualStyleBackColor = true;
            // 
            // fiveNumButton
            // 
            this.fiveNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveNumButton.Location = new System.Drawing.Point(99, 75);
            this.fiveNumButton.Name = "fiveNumButton";
            this.fiveNumButton.Size = new System.Drawing.Size(86, 50);
            this.fiveNumButton.TabIndex = 4;
            this.fiveNumButton.Text = "5";
            this.fiveNumButton.UseVisualStyleBackColor = true;
            // 
            // fourNumButton
            // 
            this.fourNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourNumButton.Location = new System.Drawing.Point(7, 75);
            this.fourNumButton.Name = "fourNumButton";
            this.fourNumButton.Size = new System.Drawing.Size(86, 50);
            this.fourNumButton.TabIndex = 3;
            this.fourNumButton.Text = "4";
            this.fourNumButton.UseVisualStyleBackColor = true;
            // 
            // threeNumButton
            // 
            this.threeNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeNumButton.Location = new System.Drawing.Point(191, 131);
            this.threeNumButton.Name = "threeNumButton";
            this.threeNumButton.Size = new System.Drawing.Size(86, 50);
            this.threeNumButton.TabIndex = 8;
            this.threeNumButton.Text = "3";
            this.threeNumButton.UseVisualStyleBackColor = true;
            // 
            // twoNumButton
            // 
            this.twoNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoNumButton.Location = new System.Drawing.Point(99, 131);
            this.twoNumButton.Name = "twoNumButton";
            this.twoNumButton.Size = new System.Drawing.Size(86, 50);
            this.twoNumButton.TabIndex = 7;
            this.twoNumButton.Text = "2";
            this.twoNumButton.UseVisualStyleBackColor = true;
            // 
            // oneNumButton
            // 
            this.oneNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneNumButton.Location = new System.Drawing.Point(7, 131);
            this.oneNumButton.Name = "oneNumButton";
            this.oneNumButton.Size = new System.Drawing.Size(86, 50);
            this.oneNumButton.TabIndex = 6;
            this.oneNumButton.Text = "1";
            this.oneNumButton.UseVisualStyleBackColor = true;
            // 
            // zeroNumButton
            // 
            this.zeroNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroNumButton.Location = new System.Drawing.Point(98, 187);
            this.zeroNumButton.Name = "zeroNumButton";
            this.zeroNumButton.Size = new System.Drawing.Size(178, 50);
            this.zeroNumButton.TabIndex = 9;
            this.zeroNumButton.Text = "0";
            this.zeroNumButton.UseVisualStyleBackColor = true;
            // 
            // clearActionButton
            // 
            this.clearActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearActionButton.Location = new System.Drawing.Point(7, 187);
            this.clearActionButton.Name = "clearActionButton";
            this.clearActionButton.Size = new System.Drawing.Size(86, 50);
            this.clearActionButton.TabIndex = 10;
            this.clearActionButton.Text = "CLR";
            this.clearActionButton.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.operationsGroupBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.TopMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.operationsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ActionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefaultViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdvancedViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        public System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.GroupBox operationsGroupBox;
        private System.Windows.Forms.Button sqrActionButton;
        private System.Windows.Forms.Button sqrtActionButton;
        private System.Windows.Forms.Button powerActionButton;
        private System.Windows.Forms.Button reverseActionButton;
        private System.Windows.Forms.Button plusActionButton;
        private System.Windows.Forms.Button subtractActionButton;
        private System.Windows.Forms.Button divideActionButton;
        private System.Windows.Forms.Button multiplyActionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button equalsActionButton;
        private System.Windows.Forms.Button clearActionButton;
        private System.Windows.Forms.Button zeroNumButton;
        private System.Windows.Forms.Button sixNumButton;
        private System.Windows.Forms.Button fiveNumButton;
        private System.Windows.Forms.Button oneNumButton;
        private System.Windows.Forms.Button fourNumButton;
        private System.Windows.Forms.Button threeNumButton;
        private System.Windows.Forms.Button twoNumButton;
        private System.Windows.Forms.Button nineNumButton;
        private System.Windows.Forms.Button eightNumButton;
        private System.Windows.Forms.Button sevenNumButton;
    }
}

