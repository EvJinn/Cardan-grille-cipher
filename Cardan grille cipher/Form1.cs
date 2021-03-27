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
            cardanGrille.SelectionChanged += cardanGrille_SelectionChanged;
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
                column.Width = 30;

            Cardan cardan = new Cardan(this);
            cardan.digitsFillGrille(Convert.ToInt32(numericUpDown1.Value));

            keyBox.Text = cardan.generateKey(Convert.ToInt32(numericUpDown1.Value));
        }

        private void cardanGrille_SelectionChanged(object sender, EventArgs e)
        {
            if (MouseButtons != System.Windows.Forms.MouseButtons.None)
                ((DataGridView)sender).CurrentCell = null;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this);
            textBox.Text = cardan.decrypt(Convert.ToString(keyBox.Text), Convert.ToString(cipherTextBox.Text), Convert.ToInt32(numericUpDown1.Value));
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this);
            cipherTextBox.Text = cardan.crypt(Convert.ToString(keyBox.Text), Convert.ToString(textBox.Text), Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
