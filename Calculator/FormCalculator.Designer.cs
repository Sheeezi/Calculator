namespace Calculator
{
    partial class FormCalculator
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
            components = new System.ComponentModel.Container();
            buttonZero = new Button();
            panelCalulator = new Panel();
            labelNumberDisplayer = new Label();
            buttonDivide = new Button();
            buttonPercent = new Button();
            buttonClear = new Button();
            buttonEquals = new Button();
            buttonEight = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonTimes = new Button();
            buttonComma = new Button();
            buttonThree = new Button();
            buttonSix = new Button();
            buttonNine = new Button();
            buttonFive = new Button();
            buttonTwo = new Button();
            buttonSeven = new Button();
            buttonFour = new Button();
            buttonOne = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelCalulator.SuspendLayout();
            SuspendLayout();
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonZero.Location = new Point(3, 272);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(102, 48);
            buttonZero.TabIndex = 0;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonNumber_Click;
            // 
            // panelCalulator
            // 
            panelCalulator.BackColor = SystemColors.ActiveCaption;
            panelCalulator.Controls.Add(labelNumberDisplayer);
            panelCalulator.Controls.Add(buttonDivide);
            panelCalulator.Controls.Add(buttonPercent);
            panelCalulator.Controls.Add(buttonClear);
            panelCalulator.Controls.Add(buttonEquals);
            panelCalulator.Controls.Add(buttonEight);
            panelCalulator.Controls.Add(buttonAdd);
            panelCalulator.Controls.Add(buttonSubtract);
            panelCalulator.Controls.Add(buttonTimes);
            panelCalulator.Controls.Add(buttonComma);
            panelCalulator.Controls.Add(buttonThree);
            panelCalulator.Controls.Add(buttonSix);
            panelCalulator.Controls.Add(buttonNine);
            panelCalulator.Controls.Add(buttonFive);
            panelCalulator.Controls.Add(buttonTwo);
            panelCalulator.Controls.Add(buttonSeven);
            panelCalulator.Controls.Add(buttonFour);
            panelCalulator.Controls.Add(buttonOne);
            panelCalulator.Controls.Add(buttonZero);
            panelCalulator.Location = new Point(274, 68);
            panelCalulator.Name = "panelCalulator";
            panelCalulator.Size = new Size(217, 323);
            panelCalulator.TabIndex = 1;
            // 
            // labelNumberDisplayer
            // 
            labelNumberDisplayer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelNumberDisplayer.Location = new Point(3, 5);
            labelNumberDisplayer.Name = "labelNumberDisplayer";
            labelNumberDisplayer.Size = new Size(210, 48);
            labelNumberDisplayer.TabIndex = 2;
            labelNumberDisplayer.Text = "0";
            labelNumberDisplayer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonDivide.Location = new Point(165, 56);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(48, 48);
            buttonDivide.TabIndex = 19;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonSign_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonPercent.Location = new Point(111, 56);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(48, 48);
            buttonPercent.TabIndex = 18;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonSign_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonClear.Location = new Point(3, 56);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(102, 48);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonEquals.Location = new Point(165, 272);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(48, 48);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonEight.Location = new Point(57, 110);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(48, 48);
            buttonEight.TabIndex = 7;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonNumber_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonAdd.Location = new Point(165, 218);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(48, 48);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonSign_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSubtract.Location = new Point(165, 164);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(48, 48);
            buttonSubtract.TabIndex = 13;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSign_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimes.Location = new Point(165, 110);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(48, 48);
            buttonTimes.TabIndex = 12;
            buttonTimes.Text = "*";
            buttonTimes.UseVisualStyleBackColor = true;
            buttonTimes.Click += buttonSign_Click;
            // 
            // buttonComma
            // 
            buttonComma.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonComma.Location = new Point(111, 272);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(48, 48);
            buttonComma.TabIndex = 11;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = true;
            buttonComma.Click += buttonNumber_Click;
            // 
            // buttonThree
            // 
            buttonThree.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonThree.Location = new Point(111, 218);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(48, 48);
            buttonThree.TabIndex = 10;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonNumber_Click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSix.Location = new Point(111, 164);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(48, 48);
            buttonSix.TabIndex = 9;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonNumber_Click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonNine.Location = new Point(111, 110);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(48, 48);
            buttonNine.TabIndex = 8;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNumber_Click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonFive.Location = new Point(57, 164);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(48, 48);
            buttonFive.TabIndex = 6;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonNumber_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTwo.Location = new Point(57, 218);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(48, 48);
            buttonTwo.TabIndex = 5;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonNumber_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSeven.Location = new Point(3, 110);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(48, 48);
            buttonSeven.TabIndex = 3;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonNumber_Click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonFour.Location = new Point(3, 164);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(48, 48);
            buttonFour.TabIndex = 2;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonNumber_Click;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonOne.Location = new Point(3, 218);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(48, 48);
            buttonOne.TabIndex = 1;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonNumber_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCalulator);
            Name = "FormCalculator";
            Text = "Calculator";
            ResizeEnd += FormCalculator_ResizeEnd;
            panelCalulator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonZero;
        private Panel panelCalulator;
        private Button buttonDivide;
        private Button buttonPercent;
        private Button buttonClear;
        private Button buttonEquals;
        private Button buttonEight;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonTimes;
        private Button buttonComma;
        private Button buttonThree;
        private Button buttonSix;
        private Button buttonNine;
        private Button buttonFive;
        private Button buttonTwo;
        private Button buttonSeven;
        private Button buttonFour;
        private Button buttonOne;
        private Label labelNumberDisplayer;
        private System.Windows.Forms.Timer timer1;
    }
}
