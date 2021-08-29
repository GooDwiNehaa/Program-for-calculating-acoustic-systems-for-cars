namespace Программа_расчета_акустических_систем
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CalculationForm2 = new System.Windows.Forms.Button();
            this.R1 = new System.Windows.Forms.TextBox();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.P3 = new System.Windows.Forms.TextBox();
            this.R3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.S12 = new System.Windows.Forms.TextBox();
            this.S1 = new System.Windows.Forms.TextBox();
            this.S2 = new System.Windows.Forms.TextBox();
            this.I = new System.Windows.Forms.TextBox();
            this.S11 = new System.Windows.Forms.TextBox();
            this.P3Calc = new System.Windows.Forms.TextBox();
            this.S3 = new System.Windows.Forms.TextBox();
            this.P2Calc = new System.Windows.Forms.TextBox();
            this.P1Calc = new System.Windows.Forms.TextBox();
            this.P11 = new System.Windows.Forms.TextBox();
            this.P12 = new System.Windows.Forms.TextBox();
            this.P13 = new System.Windows.Forms.TextBox();
            this.OutputOfResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculationForm2
            // 
            this.CalculationForm2.Location = new System.Drawing.Point(33, 459);
            this.CalculationForm2.Name = "CalculationForm2";
            this.CalculationForm2.Size = new System.Drawing.Size(100, 42);
            this.CalculationForm2.TabIndex = 1;
            this.CalculationForm2.Text = "Расчитать";
            this.CalculationForm2.UseVisualStyleBackColor = true;
            this.CalculationForm2.Click += new System.EventHandler(this.CalculationForm2_Click);
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(155, 186);
            this.R1.Multiline = true;
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(92, 25);
            this.R1.TabIndex = 7;
            this.R1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(155, 146);
            this.P1.Multiline = true;
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(92, 25);
            this.P1.TabIndex = 8;
            this.P1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(153, 255);
            this.P2.Multiline = true;
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(92, 25);
            this.P2.TabIndex = 9;
            this.P2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(153, 296);
            this.R2.Multiline = true;
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(92, 25);
            this.R2.TabIndex = 10;
            this.R2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // P3
            // 
            this.P3.Location = new System.Drawing.Point(155, 363);
            this.P3.Multiline = true;
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(92, 25);
            this.P3.TabIndex = 11;
            this.P3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // R3
            // 
            this.R3.Location = new System.Drawing.Point(155, 418);
            this.R3.Multiline = true;
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(92, 25);
            this.R3.TabIndex = 12;
            this.R3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ВЧ Динамик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Мидбассовый динами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сабвуфер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Мащность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Сопротивление";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Мощность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Сопротивление";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Мощность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Сопротивление";
            // 
            // S12
            // 
            this.S12.Location = new System.Drawing.Point(367, 28);
            this.S12.Multiline = true;
            this.S12.Name = "S12";
            this.S12.ReadOnly = true;
            this.S12.Size = new System.Drawing.Size(128, 32);
            this.S12.TabIndex = 22;
            this.S12.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // S1
            // 
            this.S1.Location = new System.Drawing.Point(400, 146);
            this.S1.Multiline = true;
            this.S1.Name = "S1";
            this.S1.ReadOnly = true;
            this.S1.Size = new System.Drawing.Size(122, 32);
            this.S1.TabIndex = 23;
            this.S1.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // S2
            // 
            this.S2.Location = new System.Drawing.Point(324, 284);
            this.S2.Multiline = true;
            this.S2.Name = "S2";
            this.S2.ReadOnly = true;
            this.S2.Size = new System.Drawing.Size(149, 32);
            this.S2.TabIndex = 24;
            this.S2.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(604, 134);
            this.I.Multiline = true;
            this.I.Name = "I";
            this.I.ReadOnly = true;
            this.I.Size = new System.Drawing.Size(123, 32);
            this.I.TabIndex = 25;
            this.I.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // S11
            // 
            this.S11.Location = new System.Drawing.Point(604, 209);
            this.S11.Multiline = true;
            this.S11.Name = "S11";
            this.S11.ReadOnly = true;
            this.S11.Size = new System.Drawing.Size(120, 32);
            this.S11.TabIndex = 26;
            this.S11.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P3Calc
            // 
            this.P3Calc.Location = new System.Drawing.Point(448, 491);
            this.P3Calc.Multiline = true;
            this.P3Calc.Name = "P3Calc";
            this.P3Calc.ReadOnly = true;
            this.P3Calc.Size = new System.Drawing.Size(131, 32);
            this.P3Calc.TabIndex = 27;
            this.P3Calc.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(760, 449);
            this.S3.Multiline = true;
            this.S3.Name = "S3";
            this.S3.ReadOnly = true;
            this.S3.Size = new System.Drawing.Size(122, 32);
            this.S3.TabIndex = 28;
            this.S3.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P2Calc
            // 
            this.P2Calc.Location = new System.Drawing.Point(813, 209);
            this.P2Calc.Multiline = true;
            this.P2Calc.Name = "P2Calc";
            this.P2Calc.ReadOnly = true;
            this.P2Calc.Size = new System.Drawing.Size(104, 32);
            this.P2Calc.TabIndex = 29;
            this.P2Calc.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P1Calc
            // 
            this.P1Calc.Location = new System.Drawing.Point(783, 108);
            this.P1Calc.Multiline = true;
            this.P1Calc.Name = "P1Calc";
            this.P1Calc.ReadOnly = true;
            this.P1Calc.Size = new System.Drawing.Size(122, 32);
            this.P1Calc.TabIndex = 30;
            this.P1Calc.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P11
            // 
            this.P11.Location = new System.Drawing.Point(560, 284);
            this.P11.Multiline = true;
            this.P11.Name = "P11";
            this.P11.ReadOnly = true;
            this.P11.Size = new System.Drawing.Size(134, 32);
            this.P11.TabIndex = 31;
            this.P11.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P12
            // 
            this.P12.Location = new System.Drawing.Point(560, 328);
            this.P12.Multiline = true;
            this.P12.Name = "P12";
            this.P12.ReadOnly = true;
            this.P12.Size = new System.Drawing.Size(134, 32);
            this.P12.TabIndex = 32;
            this.P12.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // P13
            // 
            this.P13.Location = new System.Drawing.Point(547, 384);
            this.P13.Multiline = true;
            this.P13.Name = "P13";
            this.P13.ReadOnly = true;
            this.P13.Size = new System.Drawing.Size(147, 32);
            this.P13.TabIndex = 33;
            this.P13.TextChanged += new System.EventHandler(this.S12_TextChanged);
            // 
            // OutputOfResults
            // 
            this.OutputOfResults.Location = new System.Drawing.Point(145, 449);
            this.OutputOfResults.Name = "OutputOfResults";
            this.OutputOfResults.Size = new System.Drawing.Size(100, 63);
            this.OutputOfResults.TabIndex = 34;
            this.OutputOfResults.Text = "Сохранить результаты в файл";
            this.OutputOfResults.UseVisualStyleBackColor = true;
            this.OutputOfResults.Click += new System.EventHandler(this.OutputOfResults_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 624);
            this.Controls.Add(this.OutputOfResults);
            this.Controls.Add(this.P13);
            this.Controls.Add(this.P12);
            this.Controls.Add(this.P11);
            this.Controls.Add(this.P1Calc);
            this.Controls.Add(this.P2Calc);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.P3Calc);
            this.Controls.Add(this.S11);
            this.Controls.Add(this.I);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.S12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.CalculationForm2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Двухполосная по динамикам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculationForm2;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.TextBox P3;
        private System.Windows.Forms.TextBox R3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox S12;
        private System.Windows.Forms.TextBox S1;
        private System.Windows.Forms.TextBox S2;
        private System.Windows.Forms.TextBox I;
        private System.Windows.Forms.TextBox S11;
        private System.Windows.Forms.TextBox P3Calc;
        private System.Windows.Forms.TextBox S3;
        private System.Windows.Forms.TextBox P2Calc;
        private System.Windows.Forms.TextBox P1Calc;
        private System.Windows.Forms.TextBox P11;
        private System.Windows.Forms.TextBox P12;
        private System.Windows.Forms.TextBox P13;
        private System.Windows.Forms.Button OutputOfResults;
    }
}