using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    public partial class Form5 : Form
    {
        Calculations calc;
        SaveResults saveResults;

        public Form5()
        {
            InitializeComponent();
            calc = new Calculations();
            saveResults = new SaveResults();
        }

        private bool apdateInTB = false;
        private List<string> results = new List<string>();

        private void CalculationForm2_Click(object sender, EventArgs e)
        {
            if (P11.Text != "" && P12.Text != "" && P13.Text != "" && P14.Text != "")
            {
                results = calc.ThreeWayAmp(P11.Text, P12.Text, P13.Text, P14.Text);

                P11Calc.Text = results[0];
                P12Calc.Text = results[1];
                P13Calc.Text = results[2];
                P14Calc.Text = results[3];

                P1.Text = results[4];
                P2.Text = results[5];
                P3.Text = results[6];
                P4.Text = results[7];

                S1.Text = results[8];
                S2.Text = results[9];
                S3.Text = results[10];
                S4.Text = results[11];

                S11.Text = results[12];
                S12.Text = results[13];
                I.Text = results[14];
            }
            else
            {
                MessageBox.Show("Введите все входные параметры!");
            }
        }

        private void P11_KeyPress(object sender, KeyPressEventArgs e)
        {
            calc.JustDigits(e);
        }

        private void OutputOfResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            apdateInTB = saveResults.SaveFile(saveFileDialog, results, 4);
        }

        private void S12_TextChanged(object sender, EventArgs e)
        {
            apdateInTB = true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            apdateInTB = saveResults.SaveOrClose(apdateInTB, e, saveFileDialog, results, 4);
        }
    }
}
