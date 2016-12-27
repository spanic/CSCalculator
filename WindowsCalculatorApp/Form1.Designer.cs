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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            this.sqrActionButton = new System.Windows.Forms.Button();
            this.sqrtActionButton = new System.Windows.Forms.Button();
            this.powerActionButton = new System.Windows.Forms.Button();
            this.reverseActionButton = new System.Windows.Forms.Button();
            this.plusActionButton = new System.Windows.Forms.Button();
            this.subtractActionButton = new System.Windows.Forms.Button();
            this.divideActionButton = new System.Windows.Forms.Button();
            this.multiplyActionButton = new System.Windows.Forms.Button();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.equalsActionButton = new System.Windows.Forms.Button();
            this.keyBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.decimalDividerButton = new System.Windows.Forms.Button();
            this.clearActionButton = new System.Windows.Forms.Button();
            this.zeroNumButton = new System.Windows.Forms.Button();
            this.sixNumButton = new System.Windows.Forms.Button();
            this.fiveNumButton = new System.Windows.Forms.Button();
            this.oneNumButton = new System.Windows.Forms.Button();
            this.fourNumButton = new System.Windows.Forms.Button();
            this.threeNumButton = new System.Windows.Forms.Button();
            this.twoNumButton = new System.Windows.Forms.Button();
            this.nineNumButton = new System.Windows.Forms.Button();
            this.eightNumButton = new System.Windows.Forms.Button();
            this.sevenNumButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.operationsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.factorialActionButton = new System.Windows.Forms.Button();
            this.cubeRootActionButton = new System.Windows.Forms.Button();
            this.solveEquationActionButton = new System.Windows.Forms.Button();
            this.factorialResultTextBox = new System.Windows.Forms.TextBox();
            this.equationResultTextBox = new System.Windows.Forms.TextBox();
            this.engineeringGroupBox = new System.Windows.Forms.GroupBox();
            this.topMenuStrip.SuspendLayout();
            this.operationsGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.keyBoardGroupBox.SuspendLayout();
            this.engineeringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenuItem,
            this.aboutToolStripMenuItem});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(398, 24);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Text = "menuStrip1";
            // 
            // actionsMenuItem
            // 
            this.actionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeViewMenuItem,
            this.exitMenuItem});
            this.actionsMenuItem.Name = "actionsMenuItem";
            this.actionsMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actionsMenuItem.Text = "Команды";
            // 
            // changeViewMenuItem
            // 
            this.changeViewMenuItem.CheckOnClick = true;
            this.changeViewMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeViewMenuItem.Name = "changeViewMenuItem";
            this.changeViewMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changeViewMenuItem.Text = "Инженерный вид";
            this.changeViewMenuItem.CheckedChanged += new System.EventHandler(this.changeViewMenuItem_CheckedChanged);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitMenuItem.Text = "Выход";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
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
            // sqrActionButton
            // 
            this.sqrActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrActionButton.Location = new System.Drawing.Point(282, 19);
            this.sqrActionButton.Name = "sqrActionButton";
            this.sqrActionButton.Size = new System.Drawing.Size(86, 30);
            this.sqrActionButton.TabIndex = 3;
            this.sqrActionButton.Text = "SQR";
            this.operationsToolTip.SetToolTip(this.sqrActionButton, "Возведение в квадрат");
            this.sqrActionButton.UseVisualStyleBackColor = true;
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
            this.operationsToolTip.SetToolTip(this.sqrtActionButton, "Извлечение квадратного корня");
            this.sqrtActionButton.UseVisualStyleBackColor = true;
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
            this.operationsToolTip.SetToolTip(this.powerActionButton, "Возведение в степень");
            this.powerActionButton.UseVisualStyleBackColor = true;
            this.powerActionButton.Click += new System.EventHandler(this.powerActionButton_Click);
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
            this.operationsToolTip.SetToolTip(this.reverseActionButton, "Вычисление обратного значения");
            this.reverseActionButton.UseVisualStyleBackColor = true;
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
            // actionsGroupBox
            // 
            this.actionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionsGroupBox.Controls.Add(this.equalsActionButton);
            this.actionsGroupBox.Controls.Add(this.plusActionButton);
            this.actionsGroupBox.Controls.Add(this.divideActionButton);
            this.actionsGroupBox.Controls.Add(this.subtractActionButton);
            this.actionsGroupBox.Controls.Add(this.multiplyActionButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(301, 213);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.actionsGroupBox.Size = new System.Drawing.Size(85, 246);
            this.actionsGroupBox.TabIndex = 8;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Действия";
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
            this.equalsActionButton.Click += new System.EventHandler(this.equalsActionButton_Click);
            // 
            // keyBoardGroupBox
            // 
            this.keyBoardGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keyBoardGroupBox.Controls.Add(this.decimalDividerButton);
            this.keyBoardGroupBox.Controls.Add(this.clearActionButton);
            this.keyBoardGroupBox.Controls.Add(this.zeroNumButton);
            this.keyBoardGroupBox.Controls.Add(this.sixNumButton);
            this.keyBoardGroupBox.Controls.Add(this.fiveNumButton);
            this.keyBoardGroupBox.Controls.Add(this.oneNumButton);
            this.keyBoardGroupBox.Controls.Add(this.fourNumButton);
            this.keyBoardGroupBox.Controls.Add(this.threeNumButton);
            this.keyBoardGroupBox.Controls.Add(this.twoNumButton);
            this.keyBoardGroupBox.Controls.Add(this.nineNumButton);
            this.keyBoardGroupBox.Controls.Add(this.eightNumButton);
            this.keyBoardGroupBox.Controls.Add(this.sevenNumButton);
            this.keyBoardGroupBox.Location = new System.Drawing.Point(12, 213);
            this.keyBoardGroupBox.Name = "keyBoardGroupBox";
            this.keyBoardGroupBox.Size = new System.Drawing.Size(283, 246);
            this.keyBoardGroupBox.TabIndex = 9;
            this.keyBoardGroupBox.TabStop = false;
            this.keyBoardGroupBox.Text = "Клавиатура";
            // 
            // decimalDividerButton
            // 
            this.decimalDividerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decimalDividerButton.Location = new System.Drawing.Point(191, 187);
            this.decimalDividerButton.Name = "decimalDividerButton";
            this.decimalDividerButton.Size = new System.Drawing.Size(86, 50);
            this.decimalDividerButton.TabIndex = 11;
            this.decimalDividerButton.Text = ".";
            this.decimalDividerButton.UseVisualStyleBackColor = true;
            this.decimalDividerButton.Click += new System.EventHandler(this.decimalDividerButton_Click);
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
            this.clearActionButton.Click += new System.EventHandler(this.clearActionButton_Click);
            // 
            // zeroNumButton
            // 
            this.zeroNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroNumButton.Location = new System.Drawing.Point(99, 187);
            this.zeroNumButton.Name = "zeroNumButton";
            this.zeroNumButton.Size = new System.Drawing.Size(86, 50);
            this.zeroNumButton.TabIndex = 9;
            this.zeroNumButton.Text = "0";
            this.zeroNumButton.UseVisualStyleBackColor = true;
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
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 28);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTextBox.Size = new System.Drawing.Size(374, 22);
            this.resultTextBox.TabIndex = 10;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operationsToolTip
            // 
            this.operationsToolTip.ToolTipTitle = "Описание:";
            // 
            // factorialActionButton
            // 
            this.factorialActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factorialActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorialActionButton.Location = new System.Drawing.Point(6, 21);
            this.factorialActionButton.Name = "factorialActionButton";
            this.factorialActionButton.Size = new System.Drawing.Size(86, 30);
            this.factorialActionButton.TabIndex = 4;
            this.factorialActionButton.Text = "FACT";
            this.operationsToolTip.SetToolTip(this.factorialActionButton, "Вычисление факториала");
            this.factorialActionButton.UseVisualStyleBackColor = true;
            this.factorialActionButton.Click += new System.EventHandler(this.factorialActionButton_Click);
            // 
            // cubeRootActionButton
            // 
            this.cubeRootActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cubeRootActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cubeRootActionButton.Location = new System.Drawing.Point(98, 21);
            this.cubeRootActionButton.Name = "cubeRootActionButton";
            this.cubeRootActionButton.Size = new System.Drawing.Size(86, 30);
            this.cubeRootActionButton.TabIndex = 5;
            this.cubeRootActionButton.Text = "CURT";
            this.operationsToolTip.SetToolTip(this.cubeRootActionButton, "Вычисление кубического корня");
            this.cubeRootActionButton.UseVisualStyleBackColor = true;
            // 
            // solveEquationActionButton
            // 
            this.solveEquationActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solveEquationActionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveEquationActionButton.Location = new System.Drawing.Point(190, 21);
            this.solveEquationActionButton.Name = "solveEquationActionButton";
            this.solveEquationActionButton.Size = new System.Drawing.Size(178, 30);
            this.solveEquationActionButton.TabIndex = 6;
            this.solveEquationActionButton.Text = "Quadratic Equation";
            this.operationsToolTip.SetToolTip(this.solveEquationActionButton, "Ввод и нахождение корней квадратного уравнения");
            this.solveEquationActionButton.UseVisualStyleBackColor = true;
            // 
            // factorialResultTextBox
            // 
            this.factorialResultTextBox.Location = new System.Drawing.Point(7, 58);
            this.factorialResultTextBox.Name = "factorialResultTextBox";
            this.factorialResultTextBox.ReadOnly = true;
            this.factorialResultTextBox.Size = new System.Drawing.Size(177, 22);
            this.factorialResultTextBox.TabIndex = 7;
            this.factorialResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equationResultTextBox
            // 
            this.equationResultTextBox.Location = new System.Drawing.Point(191, 58);
            this.equationResultTextBox.Name = "equationResultTextBox";
            this.equationResultTextBox.ReadOnly = true;
            this.equationResultTextBox.Size = new System.Drawing.Size(177, 22);
            this.equationResultTextBox.TabIndex = 8;
            // 
            // engineeringGroupBox
            // 
            this.engineeringGroupBox.Controls.Add(this.equationResultTextBox);
            this.engineeringGroupBox.Controls.Add(this.factorialResultTextBox);
            this.engineeringGroupBox.Controls.Add(this.solveEquationActionButton);
            this.engineeringGroupBox.Controls.Add(this.cubeRootActionButton);
            this.engineeringGroupBox.Controls.Add(this.factorialActionButton);
            this.engineeringGroupBox.Location = new System.Drawing.Point(12, 117);
            this.engineeringGroupBox.Name = "engineeringGroupBox";
            this.engineeringGroupBox.Size = new System.Drawing.Size(374, 88);
            this.engineeringGroupBox.TabIndex = 11;
            this.engineeringGroupBox.TabStop = false;
            this.engineeringGroupBox.Text = "Дополнительные команды";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 469);
            this.Controls.Add(this.engineeringGroupBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.keyBoardGroupBox);
            this.Controls.Add(this.operationsGroupBox);
            this.Controls.Add(this.topMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.operationsGroupBox.ResumeLayout(false);
            this.actionsGroupBox.ResumeLayout(false);
            this.keyBoardGroupBox.ResumeLayout(false);
            this.engineeringGroupBox.ResumeLayout(false);
            this.engineeringGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox operationsGroupBox;
        private System.Windows.Forms.Button sqrActionButton;
        private System.Windows.Forms.Button sqrtActionButton;
        private System.Windows.Forms.Button powerActionButton;
        private System.Windows.Forms.Button reverseActionButton;
        private System.Windows.Forms.Button plusActionButton;
        private System.Windows.Forms.Button subtractActionButton;
        private System.Windows.Forms.Button divideActionButton;
        private System.Windows.Forms.Button multiplyActionButton;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.GroupBox keyBoardGroupBox;
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
        private System.Windows.Forms.Button decimalDividerButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ToolTip operationsToolTip;
        private System.Windows.Forms.Button factorialActionButton;
        private System.Windows.Forms.Button cubeRootActionButton;
        private System.Windows.Forms.Button solveEquationActionButton;
        private System.Windows.Forms.TextBox factorialResultTextBox;
        private System.Windows.Forms.TextBox equationResultTextBox;
        public System.Windows.Forms.GroupBox engineeringGroupBox;
    }
}

