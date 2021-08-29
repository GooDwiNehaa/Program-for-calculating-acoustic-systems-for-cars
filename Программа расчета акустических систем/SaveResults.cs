using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Программа_расчета_акустических_систем
{
    class SaveResults
    {
        private string lastPath = "";
        public string empty;

        private void SaveDocument(string path, List<string> list, int NumberOfInputParameters)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                if (NumberOfInputParameters == 6 && list.Count > 0)
                {
                    sw.WriteLine("Номинальная мощьность ВЧ-динамика:" + list[0] + sw.NewLine +
                        "Номинальная мощьность Мидбасового динамика:" + list[1] + sw.NewLine +
                        "Номинальная мощьность Сабвуферного динамика:" + list[2] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода ВЧ-динамика:" + list[3] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Мидбасового динамика:" + list[4] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Сабвуферного динамика:" + list[5] + sw.NewLine +
                        "Номинальная мощность канала усилентия на ВЧ-динамики:" + list[6] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Мидбасовские динамики:" + list[7] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Сабвуферные динамики:" + list[8] + sw.NewLine +
                        "Рекомендуемое значение + провода:" + list[9] + sw.NewLine +
                        "Рекомендуемое сечение провода Массы:" + list[10] + sw.NewLine +
                        "Минимальное значение Предохранителя силового провода:" + list[11] + sw.NewLine);
                }
                if (NumberOfInputParameters == 3 && list.Count > 0)
                {
                    sw.WriteLine("Номинальная мощность канала усилентия на ВЧ-динамики:" + list[0] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Мидбасовские динамики:" + list[1] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Сабвуферные динамики:" + list[2] + sw.NewLine +
                        "Номинальная мощьность ВЧ-динамика:" + list[3] + sw.NewLine +
                        "Номинальная мощьность Мидбасового динамика:" + list[4] + sw.NewLine +
                        "Номинальная мощьность Сабвуферного динамика:" + list[5] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода ВЧ-динамика:" + list[6] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Мидбасового динамика:" + list[7] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Сабвуферного динамика:" + list[8] + sw.NewLine +
                        "Рекомендуемое значение + провода:" + list[9] + sw.NewLine +
                        "Рекомендуемое сечение провода Массы:" + list[10] + sw.NewLine +
                        "Минимальное значение Предохранителя силового провода:" + list[11] + sw.NewLine);
                }
                if (NumberOfInputParameters == 8 && list.Count > 0)
                {
                    sw.WriteLine("Номинальная мощьность ВЧ-динамика:" + list[0] + sw.NewLine +
                        "Номинальная мощьность Мидбасового динамика:" + list[1] + sw.NewLine +
                        "Номинальная мощьность Сабвуферного динамика:" + list[2] + sw.NewLine +
                        "Номинальная мощьность СЧ-динамика:" + list[3] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода ВЧ-динамика:" + list[4] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Мидбасового динамика:" + list[5] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Сабвуферного динамика:" + list[6] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода СЧ-динамика:" + list[7] + sw.NewLine +
                        "Номинальная мощность канала усилентия на ВЧ-динамики:" + list[8] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Мидбасовские динамики:" + list[9] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Сабвуферные динамики:" + list[10] + sw.NewLine +
                        "Номинальная мощность канала усилентия на СЧ-динамики:" + list[11] + sw.NewLine +
                        "Рекомендуемое значение + провода:" + list[12] + sw.NewLine +
                        "Рекомендуемое сечение провода Массы:" + list[13] + sw.NewLine +
                        "Минимальное значение Предохранителя силового провода:" + list[14] + sw.NewLine);
                }
                if (NumberOfInputParameters == 4 && list.Count > 0)
                {
                    sw.WriteLine("Номинальная мощность канала усилентия на ВЧ-динамики:" + list[0] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Мидбасовские динамики:" + list[1] + sw.NewLine +
                        "Номинальная мощность канала усилентия на Сабвуферные динамики:" + list[2] + sw.NewLine +
                        "Номинальная мощность канала усилентия на СЧ-динамики:" + list[3] + sw.NewLine +
                        "Номинальная мощьность ВЧ-динамика:" + list[4] + sw.NewLine +
                        "Номинальная мощьность Мидбасового динамика:" + list[5] + sw.NewLine +
                        "Номинальная мощьность Сабвуферного динамика:" + list[6] + sw.NewLine +
                        "Номинальная мощьность СЧ-динамика:" + list[7] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода ВЧ-динамика:" + list[6] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Мидбасового динамика:" + list[7] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода Сабвуферного динамика:" + list[8] + sw.NewLine +
                        "Рекомендуемое сечение акустического провода СЧ-динамика:" + list[6] + sw.NewLine +
                        "Рекомендуемое значение + провода:" + list[9] + sw.NewLine +
                        "Рекомендуемое сечение провода Массы:" + list[10] + sw.NewLine +
                        "Минимальное значение Предохранителя силового провода:" + list[11] + sw.NewLine);
                }
            }
        }

        public bool SaveFile(SaveFileDialog sfd, List<string> list, int NumberOfInputParameters)
        {
            if (lastPath != "")
            {
                SaveDocument(lastPath, list, NumberOfInputParameters);
                MessageBox.Show("Изменения успешно сохранены!");
                return false;
            }
            else
            {
                return SaveAsFile(sfd, list, NumberOfInputParameters);
            }
        }

        public bool SaveAsFile(SaveFileDialog sfd, List<string> list, int NumberOfInputParameters)
        {
            sfd.DefaultExt = "* .txt";
            sfd.Filter = "TXT Files |* .txt";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                lastPath = sfd.FileName;
                empty = sfd.FileName;
                SaveDocument(lastPath, list, NumberOfInputParameters);
                MessageBox.Show("Изменения успешно сохранены!");
                return false;
            }
            else
            {
                empty = "";
                return true;
            }
        }

        public bool SaveOrClose(bool apdateInTB, FormClosingEventArgs e, SaveFileDialog sfd, List<string> list, int NumberOfInputParameters)
        {
            if (apdateInTB == true)
            {
                DialogResult result = MessageBox.Show("Вы хотите cохранить изменения?", "Предупреждение!", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return true;
                }
                if (result == DialogResult.No)
                {
                    e.Cancel = false;
                    return false;
                }
                if (result == DialogResult.Yes)
                {
                    SaveFile(sfd, list, NumberOfInputParameters);

                    if (empty == "")
                    {
                        e.Cancel = true;
                    }

                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
