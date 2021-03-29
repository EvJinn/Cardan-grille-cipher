using System;
using System.Drawing;
using System.Text;

namespace Cardan_grille_cipher
{
    public class Cardan
    {
        public Form1 FormInstanse { set; get; }
        public Cardan(Form1 form)
        {
            FormInstanse = form; //Принимаем форму, создавшую объект класса для работы с таблицей
        }
        public void DigitsFillGrille(int k)
        {
            Random rnd = new Random();

            int[] values = new int[k * k]; //Выбранные при генерации ключа значения. Необходим для проверки повторений
            int count = k * k; //Число итераций для генерации ключа
            int a = 0; //Отдельный итератор для удобного прохождения массива значений
            int countForIter = k / 2; //Число итераций генерации ключа, для итерации одного угла решётки (чтобы выборка распределилась более-менее равномерно)
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = i * k + j + 1; //Заполняем один угол решётки числами. Расчёт по принципу прохождения одномерного массива как двумерный
                    if (count > 0 && countForIter > 0) //Проверка количества доступных итераций
                    {
                        int rand = rnd.Next(0, 2); //Случайно генерируем 0 или 1
                        if (rand == 1)                                                                      //Если выпадет 1, то:
                        {
                            FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.Red;         //Окрашиваем ячейку в красный цвет
                            values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value);  //Сохраняем полученное значение
                            a++;
                            count--;        //Уменьшаем доступное количество итераций на 1
                            countForIter--;
                        }
                    }
                }

            countForIter = k / 2; //Обновляем количество итераций на угол
            //Всё то же самое, за исключением прохождения таблицы под другим углом и расчёта значений несколько по-другому,
            //а также добавленной проверки на повторяющиеся значения в ключе, но об этом чуть ниже
            for (int i = k; i < k * 2; i++) 
                for (int j = k; j < k * 2; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = (k * 2 - i) * k + (k * 2 - j) - k;
                    if (count > 0 && countForIter > 0)
                    {
                        int rand = rnd.Next(0, 2);
                        if (rand == 1)
                        {
                            bool flag = true; //Флаг нахождения выбранного числа в массиве значений
                            for (int n = 0; n < k * k; n++) //При прохождении массива значений если число будет найдено
                            {
                                if (values[n] == Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value)) flag = false;
                                if (flag == false) break; //Опускаем флаг и выходим из цикла
                            }
                            if (flag) //Если число всё-таки будет найдено, то выполняем те же действия, что и раньше
                            {
                                FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value);
                                a++;
                                count--;
                                countForIter--;
                            }
                        }
                    }
                }

            //Всё то же самое, просто проходим решётку под другим углом и снова расчитываем значения по-другому
            countForIter = k / 2;
            for (int i = 0; i < k; i++)
                for (int j = k; j < k * 2; j++)
                {
                    FormInstanse.cardanGrille.Rows[j].Cells[i].Value = i * k + (k * 2 - j);
                    if (count > 0 && countForIter > 0)
                    {
                        int rand = rnd.Next(0, 2);
                        if (rand == 1)
                        {
                            bool flag = true;
                            for (int n = 0; n < k * k; n++)
                            {
                                if (values[n] == Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value)) flag = false;
                                if (flag == false) break;
                            }
                            if (flag)
                            {
                                FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value);
                                a++;
                                count--;
                                countForIter--;
                            }
                        }
                    }
                }

            countForIter = k / 2;
            for (int i = k; i < k * 2; i++)
                for (int j = 0; j < k; j++)
                {
                    FormInstanse.cardanGrille.Rows[j].Cells[i].Value = (k * 2 - i) * k + j - k + 1;
                    if (count > 0 && countForIter > 0)
                    {
                        int rand = rnd.Next(0, 2);
                        if (rand == 1)
                        {
                            bool flag = true;
                            for (int n = 0; n < k * k; n++)
                            {
                                if (values[n] == Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value)) flag = false;
                                if (flag == false) break;
                            }
                            if (flag)
                            {
                                FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value);
                                a++;
                                count--;
                                countForIter--;
                            }
                        }
                    }
                }

            //Если получится так, что у нас осталось некоторое количество неиспользованных итераций при генерации ключа
            if (count > 0)
            {
                for (int i = 0; i < count;) //Цикл, который будет проходиться за счёт уменьшения числа count при выполнении нужных условий
                {
                    int randIdxI = rnd.Next(0, k * 2), //Генерируем случайные индексы ячейки в таблице
                        randIdxJ = rnd.Next(0, k * 2);
                    
                    bool flag = true; //Выполняем такую же проверку на совпадение с уже имеющимися значениями
                    for (int n = 0; n < k * k; n++)
                    {
                        if (values[n] == Convert.ToInt32(FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Value)) flag = false;
                        if (flag == false) break;
                    }
                    if (flag)
                    {
                        FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Style.BackColor = Color.Red;
                        values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Value);
                        a++;
                        count--;
                    }
                }    
            }

        }

        public string GenerateKey(int k)
        {
            StringBuilder key = new StringBuilder();

            //Проходим массив и собираем строку так, что все незакрашенные ячейки будут давать 0, а закрашенные 1
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    if (FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor == Color.Red) key.Append("1");
                    else key.Append("0");

            return string.Join("", key); //Возвращаем ключ, приведя его к строке
        }

        public string Crypt(string key, string text, int k)
        {
            Random rnd = new Random();
            text = text.Replace(" ", ""); //Убираем все пробелы из текста по условию

            //Проверка соответствия длины текста и ключа
            if (text.Length > key.Length) //Если длина больше, то зашифровать сообщение полностью соответственно невозможно, о чём скажем юзеру
            {
                System.Windows.Forms.MessageBox.Show("Невозможно зашифровать сообщение данным ключом!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return "Невозможно зашифровать сообщение данным ключом!";
            }

            if (text.Length < key.Length) //Если меньше, то добьём остаток случайными буквами русского алфавита
            {
                int z = key.Length - text.Length;
                for (int i = 0; i < z; i++)
                {
                    char symb = (char)rnd.Next(0x0410, 0x44F);
                    text = text.PadRight(text.Length + 1, symb);
                }
            }

            StringBuilder cipherText = new StringBuilder();

            //Перевод ключа в двумерный массив для удобства работы с ним
            char[,] keyGrid = new char[k * 2, k * 2];
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    keyGrid[i, j] = key[i * k * 2 + j];

            //Заполняем решётку буквами в соответствии с ключом
            int a = 0;
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    if (keyGrid[i, j] == '1')
                    {
                        FormInstanse.cardanGrille.Rows[i].Cells[j].Value = Convert.ToString(text[a]);
                        a++;
                    }
                }

            //Продолжаем заполнять решётку повернув ключ на 90 градусов и так далее ещё 2 раза
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    if (keyGrid[k*2 - j - 1, i] == '1')
                    {
                        FormInstanse.cardanGrille.Rows[i].Cells[j].Value = Convert.ToString(text[a]);
                        a++;
                    }
                }

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    if (keyGrid[k * 2 - i - 1, k * 2 - j - 1] == '1')
                    {
                        FormInstanse.cardanGrille.Rows[i].Cells[j].Value = Convert.ToString(text[a]);
                        a++;
                    }
                }

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    if (keyGrid[j, k * 2 - i - 1] == '1')
                    {
                        FormInstanse.cardanGrille.Rows[i].Cells[j].Value = Convert.ToString(text[a]);
                        a++;
                    }
                }

            //Убираем выделение ключа красным и собираем полученную решётку в одну строку
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.White;
                    cipherText.Append(Convert.ToString(FormInstanse.cardanGrille.Rows[i].Cells[j].Value));
                }

            return string.Join("", cipherText); //Возвращаем зашифрованный текст приведя его к строке
        }

        public string Decrypt(string key, string cipherText, int k)
        {
            //Основной принцип тот же самый, что и шифрования, просто в обратном порядке. В комментариях не нуждается
            cipherText = cipherText.Replace(" ", "");

            if (cipherText.Length > key.Length)
            {
                System.Windows.Forms.MessageBox.Show("Невозможно расшифровать сообщение данным ключом!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return "Невозможно расшифровать сообщение данным ключом!";
            }

            StringBuilder text = new StringBuilder();

            char[,] keyGrid = new char[k * 2, k * 2];
            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    keyGrid[i, j] = key[i * k * 2 + j];

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.White;
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = Convert.ToString(cipherText[i * k * 2 + j]);
                }

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    if (keyGrid[i, j] == '1')
                        text.Append(Convert.ToString(FormInstanse.cardanGrille.Rows[i].Cells[j].Value));

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    if (keyGrid[k * 2 - j - 1, i] == '1')
                        text.Append(Convert.ToString(FormInstanse.cardanGrille.Rows[i].Cells[j].Value));

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    if (keyGrid[k * 2 - i - 1, k * 2 - j - 1] == '1')
                        text.Append(Convert.ToString(FormInstanse.cardanGrille.Rows[i].Cells[j].Value));

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    if (keyGrid[j, k * 2 - i - 1] == '1')
                        text.Append(Convert.ToString(FormInstanse.cardanGrille.Rows[i].Cells[j].Value));

            for (int i = 0; i < k * 2; i++)
                for (int j = 0; j < k * 2; j++)
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.White;

            return string.Join("", text);
        }

    }
}
