using System;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DynamicHeads.Checked == false && Amplifiers.Checked == false || Trunk.Checked == false && UnderTheSeat.Checked == false ||
                SmallAuto.Checked == false && BigAuto.Checked == false || DualBandAndSubwoofer.Checked == false && ThreeWayAndSubwoofer.Checked == false)
            {
                MessageBox.Show("Выберите в каждом блоке один пункт!");
            }

            if (DynamicHeads.Checked && Trunk.Checked && BigAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 1;

                Form2 form2 = new Form2();
                form2.Show();
            }
            if (DynamicHeads.Checked && UnderTheSeat.Checked && BigAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 0.5;

                Form2 form2 = new Form2();
                form2.Show();
            }
            if (DynamicHeads.Checked && UnderTheSeat.Checked && SmallAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 0.5;

                Form2 form2 = new Form2();
                form2.Show();
            }
            if (DynamicHeads.Checked && Trunk.Checked && SmallAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 1;

                Form2 form2 = new Form2();
                form2.Show();
            }
            if (Amplifiers.Checked && Trunk.Checked && SmallAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 1;

                Form3 form3 = new Form3();
                form3.Show();
            }
            if (Amplifiers.Checked && UnderTheSeat.Checked && SmallAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 0.5;

                Form3 form3 = new Form3();
                form3.Show();
            }
            if (Amplifiers.Checked && UnderTheSeat.Checked && BigAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 0.5;

                Form3 form3 = new Form3();
                form3.Show();
            }
            if (Amplifiers.Checked && Trunk.Checked && BigAuto.Checked && DualBandAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 1;

                Form3 form3 = new Form3();
                form3.Show();
            }
            if (DynamicHeads.Checked && Trunk.Checked && BigAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 1;

                Form4 form4 = new Form4();
                form4.Show();
            }
            if (DynamicHeads.Checked && UnderTheSeat.Checked && BigAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 0.5;

                Form4 form4 = new Form4();
                form4.Show();
            }
            if (DynamicHeads.Checked && UnderTheSeat.Checked && SmallAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 0.5;

                Form4 form4 = new Form4();
                form4.Show();
            }
            if (DynamicHeads.Checked && Trunk.Checked && SmallAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 1;

                Form4 form4 = new Form4();
                form4.Show();
            }
            if (Amplifiers.Checked && Trunk.Checked && SmallAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 1;

                Form5 form5 = new Form5();
                form5.Show();
            }
            if (Amplifiers.Checked && UnderTheSeat.Checked && SmallAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 4;
                Data.ValueD1 = 0.5;

                Form5 form5 = new Form5();
                form5.Show();
            }
            if (Amplifiers.Checked && UnderTheSeat.Checked && BigAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 0.5;

                Form5 form5 = new Form5();
                form5.Show();
            }
            if (Amplifiers.Checked && Trunk.Checked && BigAuto.Checked && ThreeWayAndSubwoofer.Checked)
            {
                Data.ValueD = 5.5;
                Data.ValueD1 = 1;

                Form5 form5 = new Form5();
                form5.Show();
            }
        }
    }
}
