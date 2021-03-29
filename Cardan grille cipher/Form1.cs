using System;
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

        private void numericUpDown1_ValueChanged(Object sender, EventArgs e) //Событие изменения размерности малой решётки
        {
            //int k = Convert.ToInt32(numericUpDown1.Value);
            cardanGrille.Rows.Clear();
            cardanGrille.RowCount = Convert.ToInt32(numericUpDown1.Value) * 2;
            cardanGrille.ColumnCount = Convert.ToInt32(numericUpDown1.Value) * 2;
            foreach (DataGridViewColumn column in cardanGrille.Columns)
                column.Width = 30;

            Cardan cardan = new Cardan(this); //Объект класса. Принимает эту форму в конструкторе
            cardan.DigitsFillGrille(Convert.ToInt32(numericUpDown1.Value)); //Заполнение решётки числами, параллельно генерируется ключ

            keyBox.Text = cardan.GenerateKey(Convert.ToInt32(numericUpDown1.Value)); //Генерация ключа по выделенным клеткам в решётке
        }

        private void cardanGrille_SelectionChanged(object sender, EventArgs e) //Отмена выделения на сетке
        {
            if (MouseButtons != MouseButtons.None)
                ((DataGridView)sender).CurrentCell = null;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this); 
            textBox.Text = cardan.Decrypt(Convert.ToString(keyBox.Text), Convert.ToString(cipherTextBox.Text), Convert.ToInt32(numericUpDown1.Value)); //Расшифровываем
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Cardan cardan = new Cardan(this);
            cipherTextBox.Text = cardan.Crypt(Convert.ToString(keyBox.Text), Convert.ToString(textBox.Text), Convert.ToInt32(numericUpDown1.Value)); //Шифруем
        }
    }
}
