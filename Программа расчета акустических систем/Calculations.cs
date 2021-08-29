using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    class Calculations
    {
        public List<string> TwoWaySpeakers(string P1, string R1, string P2, string R2, string P3, string R3)
        {
            List<string> results = new List<string>();

            double p1 = Convert.ToDouble(P1);
            results.Add(p1.ToString("0.00") + "Вт");
            double r1 = Convert.ToDouble(R1);
            double p2 = Convert.ToDouble(P2);
            results.Add(p2.ToString("0.00") + "Вт");
            double r2 = Convert.ToDouble(R2);
            double p3 = Convert.ToDouble(P3);
            results.Add(p3.ToString("0.00") + "Вт");
            double r3 = Convert.ToDouble(R3);

            double s1 = (2 * p1 / 12) / 10;
            results.Add(s1.ToString("0.00") + "мм^2");
            double s2 = (4 * p2 / 12) / 10;
            results.Add(s2.ToString("0.00") + "мм^2");
            double s3 = (4 * p3 / 12) / 10;
            results.Add(s3.ToString("0.00") + "мм^2");

            double p11 = p1 * r1 / 4;
            results.Add(p11.ToString("0.00") + "Вт");
            double p12 = 1.25 * (p2 * r2 / 4);
            results.Add(p12.ToString("0.00") + "Вт");
            double p13 = 1.5 * (p3 * r3 / 4);
            results.Add(p13.ToString("0.00") + "Вт");

            double s11 = 2 * Data.ValueD * Data.ValueD1 * ((p11 + p12 + p13) / (13.4 * 1)) * 0.175 / 2;
            results.Add(s11.ToString("0.00") + "мм^2");
            double s12 = s11;
            results.Add(s12.ToString("0.00") + "мм^2");
            double i = 3 * s11;
            results.Add(i.ToString("0.00") + "А");

            return results;
        }

        public List<string> TwoWayAmp(string P11, string P12, string P13)
        {
            List<string> results = new List<string>();

            double p11 = Convert.ToDouble(P11);
            results.Add(p11.ToString("0.00") + "Вт");
            double p12 = Convert.ToDouble(P12);
            results.Add(p12.ToString("0.00") + "Вт");
            double p13 = Convert.ToDouble(P13);
            results.Add(p13.ToString("0.00") + "Вт");

            double p1 = p11;
            results.Add(p1.ToString("0.00") + "Вт");
            double p2 = 0.8 * p12;
            results.Add(p2.ToString("0.00") + "Вт");
            double p3 = 0.7 * p13;
            results.Add(p3.ToString("0.00") + "Вт");

            double s1 = (2 * p1 / 12) / 10;
            results.Add(s1.ToString("0.00") + "мм^2");
            double s2 = (4 * p2 / 12) / 10;
            results.Add(s2.ToString("0.00") + "мм^2");
            double s3 = (4 * p3 / 12) / 10;
            results.Add(s3.ToString("0.00") + "мм^2");

            double s11 = 2 * Data.ValueD * Data.ValueD1 * ((p11 + p12 + p13) / (13.4 * 1)) * 0.175 / 2;
            results.Add(s11.ToString("0.00") + "мм^2");
            double s12 = s11;
            results.Add(s12.ToString("0.00") + "мм^2");
            double i = 3 * s11;
            results.Add(i.ToString("0.00") + "А");

            return results;
        }

        public List<string> ThreeWaySpeakers(string P1, string R1, string P2, string R2, string P3, string R3, string P4, string R4)
        {
            List<string> results = new List<string>();

            double p1 = Convert.ToDouble(P1);
            results.Add(p1.ToString("0.00") + "Вт");
            double r1 = Convert.ToDouble(R1);
            double p2 = Convert.ToDouble(P2);
            results.Add(p2.ToString("0.00") + "Вт");
            double r2 = Convert.ToDouble(R2);
            double p3 = Convert.ToDouble(P3);
            results.Add(p3.ToString("0.00") + "Вт");
            double r3 = Convert.ToDouble(R3);
            double p4 = Convert.ToDouble(P4);
            results.Add(p4.ToString("0.00") + "Вт");
            double r4 = Convert.ToDouble(R4);

            double s1 = (2 * p1 / 12) / 10;
            results.Add(s1.ToString("0.00") + "мм^2");
            double s2 = (4 * p2 / 12) / 10;
            results.Add(s2.ToString("0.00") + "мм^2");
            double s3 = (4 * p3 / 12) / 10;
            results.Add(s3.ToString("0.00") + "мм^2");
            double s4 = (2 * p4 / 12) / 10;
            results.Add(s4.ToString("0.00") + "мм^2");

            double p11 = p1 * r1 / 4;
            results.Add(p11.ToString("0.00") + "Вт");
            double p12 = 1.25 * (p2 * r2 / 4);
            results.Add(p12.ToString("0.00") + "Вт");
            double p13 = 1.5 * (p3 * r3 / 4);
            results.Add(p13.ToString("0.00") + "Вт");
            double p14 = p4 * r4 / 4;
            results.Add(p14.ToString("0.00") + "Вт");

            double s11 = 2 * Data.ValueD * Data.ValueD1 * ((p11 + p12 + p13 + p14) / (13.4 * 1)) * 0.175 / 2;
            results.Add(s11.ToString("0.00") + "мм^2");
            double s12 = s11;
            results.Add(s12.ToString("0.00") + "мм^2");
            double i = 3 * s11;
            results.Add(i.ToString("0.00") + "А");

            return results;
        }

        public List<string> ThreeWayAmp(string P11, string P12, string P13, string P14)
        {
            List<string> results = new List<string>();

            double p11 = Convert.ToDouble(P11);
            results.Add(p11.ToString("0.00") + "Вт");
            double p12 = Convert.ToDouble(P12);
            results.Add(p12.ToString("0.00") + "Вт");
            double p13 = Convert.ToDouble(P13);
            results.Add(p13.ToString("0.00") + "Вт");
            double p14 = Convert.ToDouble(P14);
            results.Add(p14.ToString("0.00") + "Вт");

            double p1 = p11;
            results.Add(p1.ToString("0.00") + "Вт");
            double p2 = 0.8 * p12;
            results.Add(p2.ToString("0.00") + "Вт");
            double p3 = 0.7 * p13;
            results.Add(p3.ToString("0.00") + "Вт");
            double p4 = p14;
            results.Add(p1.ToString("0.00") + "Вт");

            double s1 = (2 * p1 / 12) / 10;
            results.Add(s1.ToString("0.00") + "мм^2");
            double s2 = (4 * p2 / 12) / 10;
            results.Add(s2.ToString("0.00") + "мм^2");
            double s3 = (4 * p3 / 12) / 10;
            results.Add(s3.ToString("0.00") + "мм^2");
            double s4 = (2 * p1 / 12) / 10;
            results.Add(s4.ToString("0.00") + "мм^2");

            double s11 = 2 * Data.ValueD * Data.ValueD1 * ((p11 + p12 + p13 + p14) / (13.4 * 1)) * 0.175 / 2;
            results.Add(s11.ToString("0.00") + "мм^2");
            double s12 = s11;
            results.Add(s12.ToString("0.00") + "мм^2");
            double i = 3 * s11;
            results.Add(i.ToString("0.00") + "А");

            return results;
        }

        public void JustDigits(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
