using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardan_grille_cipher
{
    public class Cardan
    {
        public Form1 FormInstanse { set; get; }
        public Cardan(Form1 form)
        {
            FormInstanse = form;
        }
        public void digitsFillGrille(int k)
        {
            Random rnd = new Random();
            int[] values = new int[k * k];
            int count = k * k;
            int a = 0;
            int countForIter = k / 2;
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = i * k + j + 1;
                    if (count > 0 && countForIter > 0)
                    {
                        int rand = rnd.Next(0, 2);
                        if (rand == 1)
                        {
                            FormInstanse.cardanGrille.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[i].Cells[j].Value);
                            a++;
                            count--;
                            countForIter--;
                        }
                    }
                }

            countForIter = k / 2;
            for (int i = k; i < k * 2; i++)
                for (int j = k; j < k * 2; j++)
                {
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = (k * 2 - i) * k + (k * 2 - j) - k;
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
                            if (flag == true)
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
                            if (flag == true)
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
                            if (flag == true)
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

            if (count > 0)
            {
                for (int i = 0; i < count;)
                {
                    int randIdxI = rnd.Next(0, k * 2),
                        randIdxJ = rnd.Next(0, k * 2);
                    
                    bool flag = true;
                    for (int n = 0; n < k * k; n++)
                    {
                        if (values[n] == Convert.ToInt32(FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Value)) flag = false;
                        if (flag == false) break;
                    }
                    if (flag == true)
                    {
                        FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Style.BackColor = Color.Red;
                        values[a] = Convert.ToInt32(FormInstanse.cardanGrille.Rows[randIdxI].Cells[randIdxJ].Value);
                        a++;
                        count--;
                    }
                }    
            }

        }

        public void crypt()
        {

        }

        public void decrypt()
        {

        }

    }
}
