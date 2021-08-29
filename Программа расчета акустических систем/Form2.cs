using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    public partial class Form2 : Form
    {
        Calculations calc;
        SaveResults saveResults;
        public Form2()
        {
            InitializeComponent();
            calc = new Calculations();
            saveResults = new SaveResults();
        }


        private bool apdateInTB = false;
        private List<string> results = new List<string>();

        private void CalculationForm2_Click(object sender, EventArgs e)
        {
            if (P1.Text != "" && R1.Text != "" && P2.Text != "" && R2.Text != "" && P3.Text != "" && R3.Text != "")
            {
                results = calc.TwoWaySpeakers(P1.Text, R1.Text, P2.Text, R2.Text, P3.Text, R3.Text);

                P1Calc.Text = results[0];
                P2Calc.Text = results[1];
                P3Calc.Text = results[2];

                S1.Text = results[3];
                S2.Text = results[4];
                S3.Text = results[5];

                P11.Text = results[6];
                P12.Text = results[7];
                P13.Text = results[8];

                S11.Text = results[9];
                S12.Text = results[10];
                I.Text = results[11];
            }
            else
            {
                MessageBox.Show("Введите все входные параметры!");
            }
        }

        private void P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            calc.JustDigits(e);
        }

        private void OutputOfResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            apdateInTB = saveResults.SaveFile(saveFileDialog, results, 6);
        }

        private void S12_TextChanged(object sender, EventArgs e)
        {
            apdateInTB = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            apdateInTB = saveResults.SaveOrClose(apdateInTB, e, saveFileDialog, results, 6);
        }
    }
}
