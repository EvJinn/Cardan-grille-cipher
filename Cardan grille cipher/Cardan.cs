using System;
using System.Collections.Generic;
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
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = i * k + j + 1;

            for (int i = k; i < k * 2; i++)
                for (int j = k ; j < k * 2; j++)
                    FormInstanse.cardanGrille.Rows[i].Cells[j].Value = (k * 2 - i) * k + (k * 2 - j) - k;

            for (int i = 0; i < k; i++)
                for (int j = k ; j < k * 2; j++)
                    FormInstanse.cardanGrille.Rows[j].Cells[i].Value = i * k + (k * 2 - j);

            for (int i = k; i < k * 2; i++)
                for (int j = 0; j < k; j++)
                    FormInstanse.cardanGrille.Rows[j].Cells[i].Value = (k * 2 - i) * k + j - k + 1;
        }

        public void crypt()
        {

        }

        public void decrypt()
        {

        }

    }
}
