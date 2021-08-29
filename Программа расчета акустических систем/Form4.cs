using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    public partial class Form4 : Form
    {
        Calculations calc;
        SaveResults saveResults;

        public Form4()
        {
            InitializeComponent();
            calc = new Calculations();
            saveResults = new SaveResults();
        }

        private bool apdateInTB = false;
        private List<string> results = new List<string>();

        private void CalculationForm2_Click(object sender, EventArgs e)
        {
            if (P1.Text != "" && R1.Text != "" && P2.Text != "" && R2.Text != "" && P3.Text != "" && R3.Text != "" && P4.Text != "" && R4.Text != "")
            {
                results = calc.ThreeWaySpeakers(P1.Text, R1.Text, P2.Text, R2.Text, P3.Text, R3.Text, P4.Text, R4.Text);

                P1Calc.Text = results[0];
                P2Calc.Text = results[1];
                P3Calc.Text = results[2];
                P4Calc.Text = results[3];

                S1.Text = results[4];
                S2.Text = results[5];
                S3.Text = results[6];
                S4.Text = results[7];

                P11.Text = results[8];
                P12.Text = results[9];
                P13.Text = results[10];
                P14.Text = results[11];

                S11.Text = results[12];
                S12.Text = results[13];
                I.Text = results[14];
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
            apdateInTB = saveResults.SaveFile(saveFileDialog, results, 8);
        }

        private void S12_TextChanged(object sender, EventArgs e)
        {
            apdateInTB = true;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            apdateInTB = saveResults.SaveOrClose(apdateInTB, e, saveFileDialog, results, 8);
        }
    }
}
