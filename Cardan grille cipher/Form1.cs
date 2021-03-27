using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardan_grille_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }

        private void numericUpDown1_ValueChanged(Object sender, EventArgs e)
        {
            //int k = Convert.ToInt32(numericUpDown1.Value);
            cardanGrille.Rows.Clear();
            cardanGrille.RowCount = Convert.ToInt32(numericUpDown1.Value) * 2;
            cardanGrille.ColumnCount = Convert.ToInt32(numericUpDown1.Value) * 2;
            foreach (DataGridViewColumn column in cardanGrille.Columns)
                column.Width = 25;

            Cardan cardan = new Cardan(this);
            cardan.digitsFillGrille(Convert.ToInt32(numericUpDown1.Value));
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this);
            cardan.decrypt();
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this);
            cardan.crypt();
        }
    }
}
