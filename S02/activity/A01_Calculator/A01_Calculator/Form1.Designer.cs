namespace A01_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlus = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnErase = new Button();
            btnTimes = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnEquals = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            button1 = new Button();
            textDisplay = new TextBox();
            textEquation = new TextBox();
            textHistory = new TextBox();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = Color.Firebrick;
            btnPlus.Location = new Point(93, 302);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(38, 46);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operator;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.ForeColor = Color.Firebrick;
            btnDot.Location = new Point(47, 302);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(40, 46);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Load_Key;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(4, 302);
            btn0.Name = "btn0";
            btn0.Size = new Size(37, 46);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Load_Key;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(93, 250);
            btn3.Name = "btn3";
            btn3.Size = new Size(38, 46);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Load_Key;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(47, 250);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 46);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Load_Key;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(5, 250);
            btn1.Name = "btn1";
            btn1.Size = new Size(36, 46);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Load_Key;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(93, 198);
            btn6.Name = "btn6";
            btn6.Size = new Size(38, 46);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Load_Key;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(47, 198);
            btn5.Name = "btn5";
            btn5.Size = new Size(40, 46);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Load_Key;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(5, 198);
            btn4.Name = "btn4";
            btn4.Size = new Size(36, 46);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Load_Key;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(93, 146);
            btn9.Name = "btn9";
            btn9.Size = new Size(38, 46);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Load_Key;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(47, 146);
            btn8.Name = "btn8";
            btn8.Size = new Size(40, 46);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Load_Key;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(5, 146);
            btn7.Name = "btn7";
            btn7.Size = new Size(36, 46);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Load_Key;
            // 
            // btnErase
            // 
            btnErase.Font = new Font("Showcard Gothic", 18F);
            btnErase.Location = new Point(122, 94);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(55, 34);
            btnErase.TabIndex = 15;
            btnErase.Text = "⌫";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.ForeColor = Color.Firebrick;
            btnTimes.Location = new Point(138, 146);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(44, 46);
            btnTimes.TabIndex = 16;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += Operator;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = Color.Firebrick;
            btnDivide.Location = new Point(138, 198);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(44, 46);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operator;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.Firebrick;
            btnMinus.Location = new Point(138, 250);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(44, 46);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += Operator;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.ForeColor = Color.Firebrick;
            btnEquals.Location = new Point(137, 302);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(45, 46);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Showcard Gothic", 18F);
            btnDelete.Location = new Point(71, 94);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(45, 34);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(12, 94);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(53, 34);
            btnClear.TabIndex = 21;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(207, 14);
            button1.Name = "button1";
            button1.Size = new Size(21, 30);
            button1.TabIndex = 22;
            button1.Text = "-\r\n-\r\n-\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textDisplay
            // 
            textDisplay.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.Location = new Point(5, 50);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(223, 28);
            textDisplay.TabIndex = 23;
            // 
            // textEquation
            // 
            textEquation.BackColor = SystemColors.Window;
            textEquation.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textEquation.ForeColor = Color.Black;
            textEquation.Location = new Point(5, 12);
            textEquation.Multiline = true;
            textEquation.Name = "textEquation";
            textEquation.Size = new Size(197, 32);
            textEquation.TabIndex = 24;
            textEquation.TextChanged += textEquation_TextChanged;
            // 
            // textHistory
            // 
            textHistory.BackColor = Color.WhiteSmoke;
            textHistory.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textHistory.ForeColor = SystemColors.ControlText;
            textHistory.Location = new Point(234, 11);
            textHistory.Multiline = true;
            textHistory.Name = "textHistory";
            textHistory.Size = new Size(108, 337);
            textHistory.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(354, 352);
            Controls.Add(textHistory);
            Controls.Add(textEquation);
            Controls.Add(textDisplay);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEquals);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(btnTimes);
            Controls.Add(btnErase);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnDot;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnErase;
        private Button btnTimes;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnEquals;
        private Button btnDelete;
        private Button btnClear;
        private Button button1;
        private TextBox textDisplay;
        private TextBox textEquation;
        private TextBox textHistory;
    }
}
