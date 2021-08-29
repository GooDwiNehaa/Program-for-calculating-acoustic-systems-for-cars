namespace Программа_расчета_акустических_систем
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Further = new System.Windows.Forms.Button();
            this.DynamicHeads = new System.Windows.Forms.RadioButton();
            this.Amplifiers = new System.Windows.Forms.RadioButton();
            this.TypeOfCalculation = new System.Windows.Forms.GroupBox();
            this.Location = new System.Windows.Forms.GroupBox();
            this.UnderTheSeat = new System.Windows.Forms.RadioButton();
            this.Trunk = new System.Windows.Forms.RadioButton();
            this.CarType = new System.Windows.Forms.GroupBox();
            this.BigAuto = new System.Windows.Forms.RadioButton();
            this.SmallAuto = new System.Windows.Forms.RadioButton();
            this.TypeOfAcoustics = new System.Windows.Forms.GroupBox();
            this.ThreeWayAndSubwoofer = new System.Windows.Forms.RadioButton();
            this.DualBandAndSubwoofer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeOfCalculation.SuspendLayout();
            this.Location.SuspendLayout();
            this.CarType.SuspendLayout();
            this.TypeOfAcoustics.SuspendLayout();
            this.SuspendLayout();
            // 
            // Further
            // 
            this.Further.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Further.Location = new System.Drawing.Point(856, 403);
            this.Further.Name = "Further";
            this.Further.Size = new System.Drawing.Size(116, 43);
            this.Further.TabIndex = 12;
            this.Further.Text = "Далее";
            this.Further.UseVisualStyleBackColor = true;
            this.Further.Click += new System.EventHandler(this.button1_Click);
            // 
            // DynamicHeads
            // 
            this.DynamicHeads.AutoSize = true;
            this.DynamicHeads.Location = new System.Drawing.Point(6, 21);
            this.DynamicHeads.Name = "DynamicHeads";
            this.DynamicHeads.Size = new System.Drawing.Size(124, 21);
            this.DynamicHeads.TabIndex = 14;
            this.DynamicHeads.TabStop = true;
            this.DynamicHeads.Text = "По динамикам";
            this.DynamicHeads.UseVisualStyleBackColor = true;
            // 
            // Amplifiers
            // 
            this.Amplifiers.AutoSize = true;
            this.Amplifiers.Location = new System.Drawing.Point(190, 21);
            this.Amplifiers.Name = "Amplifiers";
            this.Amplifiers.Size = new System.Drawing.Size(129, 21);
            this.Amplifiers.TabIndex = 15;
            this.Amplifiers.TabStop = true;
            this.Amplifiers.Text = "По усилителям";
            this.Amplifiers.UseVisualStyleBackColor = true;
            // 
            // TypeOfCalculation
            // 
            this.TypeOfCalculation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TypeOfCalculation.Controls.Add(this.DynamicHeads);
            this.TypeOfCalculation.Controls.Add(this.Amplifiers);
            this.TypeOfCalculation.Location = new System.Drawing.Point(52, 336);
            this.TypeOfCalculation.Name = "TypeOfCalculation";
            this.TypeOfCalculation.Size = new System.Drawing.Size(335, 49);
            this.TypeOfCalculation.TabIndex = 16;
            this.TypeOfCalculation.TabStop = false;
            // 
            // Location
            // 
            this.Location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Location.Controls.Add(this.UnderTheSeat);
            this.Location.Controls.Add(this.Trunk);
            this.Location.Location = new System.Drawing.Point(450, 336);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(333, 46);
            this.Location.TabIndex = 17;
            this.Location.TabStop = false;
            // 
            // UnderTheSeat
            // 
            this.UnderTheSeat.AutoSize = true;
            this.UnderTheSeat.Location = new System.Drawing.Point(6, 21);
            this.UnderTheSeat.Name = "UnderTheSeat";
            this.UnderTheSeat.Size = new System.Drawing.Size(122, 21);
            this.UnderTheSeat.TabIndex = 1;
            this.UnderTheSeat.TabStop = true;
            this.UnderTheSeat.Text = "Под сиденьем";
            this.UnderTheSeat.UseVisualStyleBackColor = true;
            // 
            // Trunk
            // 
            this.Trunk.AutoSize = true;
            this.Trunk.Location = new System.Drawing.Point(221, 21);
            this.Trunk.Name = "Trunk";
            this.Trunk.Size = new System.Drawing.Size(91, 21);
            this.Trunk.TabIndex = 0;
            this.Trunk.TabStop = true;
            this.Trunk.Text = "Багажник";
            this.Trunk.UseVisualStyleBackColor = true;
            // 
            // CarType
            // 
            this.CarType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarType.Controls.Add(this.BigAuto);
            this.CarType.Controls.Add(this.SmallAuto);
            this.CarType.Location = new System.Drawing.Point(59, 591);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(328, 43);
            this.CarType.TabIndex = 18;
            this.CarType.TabStop = false;
            // 
            // BigAuto
            // 
            this.BigAuto.AutoSize = true;
            this.BigAuto.Location = new System.Drawing.Point(207, 16);
            this.BigAuto.Name = "BigAuto";
            this.BigAuto.Size = new System.Drawing.Size(88, 21);
            this.BigAuto.TabIndex = 1;
            this.BigAuto.TabStop = true;
            this.BigAuto.Text = "Большой";
            this.BigAuto.UseVisualStyleBackColor = true;
            // 
            // SmallAuto
            // 
            this.SmallAuto.AutoSize = true;
            this.SmallAuto.Location = new System.Drawing.Point(6, 22);
            this.SmallAuto.Name = "SmallAuto";
            this.SmallAuto.Size = new System.Drawing.Size(102, 21);
            this.SmallAuto.TabIndex = 0;
            this.SmallAuto.TabStop = true;
            this.SmallAuto.Text = "Маленький";
            this.SmallAuto.UseVisualStyleBackColor = true;
            // 
            // TypeOfAcoustics
            // 
            this.TypeOfAcoustics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TypeOfAcoustics.Controls.Add(this.ThreeWayAndSubwoofer);
            this.TypeOfAcoustics.Controls.Add(this.DualBandAndSubwoofer);
            this.TypeOfAcoustics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeOfAcoustics.Location = new System.Drawing.Point(450, 591);
            this.TypeOfAcoustics.Name = "TypeOfAcoustics";
            this.TypeOfAcoustics.Size = new System.Drawing.Size(333, 43);
            this.TypeOfAcoustics.TabIndex = 19;
            this.TypeOfAcoustics.TabStop = false;
            // 
            // ThreeWayAndSubwoofer
            // 
            this.ThreeWayAndSubwoofer.AutoSize = true;
            this.ThreeWayAndSubwoofer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ThreeWayAndSubwoofer.Location = new System.Drawing.Point(221, 21);
            this.ThreeWayAndSubwoofer.Name = "ThreeWayAndSubwoofer";
            this.ThreeWayAndSubwoofer.Size = new System.Drawing.Size(87, 21);
            this.ThreeWayAndSubwoofer.TabIndex = 1;
            this.ThreeWayAndSubwoofer.TabStop = true;
            this.ThreeWayAndSubwoofer.Text = "3-х + саб";
            this.ThreeWayAndSubwoofer.UseVisualStyleBackColor = true;
            // 
            // DualBandAndSubwoofer
            // 
            this.DualBandAndSubwoofer.AutoSize = true;
            this.DualBandAndSubwoofer.Location = new System.Drawing.Point(6, 21);
            this.DualBandAndSubwoofer.Name = "DualBandAndSubwoofer";
            this.DualBandAndSubwoofer.Size = new System.Drawing.Size(87, 21);
            this.DualBandAndSubwoofer.TabIndex = 0;
            this.DualBandAndSubwoofer.TabStop = true;
            this.DualBandAndSubwoofer.Text = "2-х + саб";
            this.DualBandAndSubwoofer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Тип расчета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Тип автомобиля:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Расположение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Тип акустики:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfAcoustics);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.TypeOfCalculation);
            this.Controls.Add(this.Further);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Программа расчета акустических систем";
            this.TypeOfCalculation.ResumeLayout(false);
            this.TypeOfCalculation.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.CarType.ResumeLayout(false);
            this.CarType.PerformLayout();
            this.TypeOfAcoustics.ResumeLayout(false);
            this.TypeOfAcoustics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Further;
        private System.Windows.Forms.RadioButton DynamicHeads;
        private System.Windows.Forms.RadioButton Amplifiers;
        private System.Windows.Forms.GroupBox TypeOfCalculation;
        private System.Windows.Forms.GroupBox Location;
        private System.Windows.Forms.RadioButton UnderTheSeat;
        private System.Windows.Forms.RadioButton Trunk;
        private System.Windows.Forms.GroupBox CarType;
        private System.Windows.Forms.RadioButton BigAuto;
        private System.Windows.Forms.RadioButton SmallAuto;
        private System.Windows.Forms.GroupBox TypeOfAcoustics;
        private System.Windows.Forms.RadioButton ThreeWayAndSubwoofer;
        private System.Windows.Forms.RadioButton DualBandAndSubwoofer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

