
namespace Cardan_grille_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cardanGrille = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonCrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardanGrille)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифруемый текст";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(147, 10);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(641, 22);
            this.textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размерность малой решётки k";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(229, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // cardanGrille
            // 
            this.cardanGrille.AllowUserToAddRows = false;
            this.cardanGrille.AllowUserToDeleteRows = false;
            this.cardanGrille.AllowUserToResizeColumns = false;
            this.cardanGrille.AllowUserToResizeRows = false;
            this.cardanGrille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardanGrille.ColumnHeadersVisible = false;
            this.cardanGrille.Location = new System.Drawing.Point(16, 64);
            this.cardanGrille.Name = "cardanGrille";
            this.cardanGrille.ReadOnly = true;
            this.cardanGrille.RowHeadersVisible = false;
            this.cardanGrille.RowHeadersWidth = 51;
            this.cardanGrille.RowTemplate.Height = 25;
            this.cardanGrille.Size = new System.Drawing.Size(772, 329);
            this.cardanGrille.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ключ";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(15, 421);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(377, 156);
            this.keyBox.TabIndex = 6;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(398, 421);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(390, 156);
            this.cipherTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зашифрованный текст";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(629, 583);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(159, 30);
            this.buttonDecrypt.TabIndex = 9;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Location = new System.Drawing.Point(464, 583);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(159, 30);
            this.buttonCrypt.TabIndex = 10;
            this.buttonCrypt.Text = "Зашифровать";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            this.buttonCrypt.Click += new System.EventHandler(this.buttonCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.buttonCrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardanGrille);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Шифр решётка Кардано";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardanGrille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonCrypt;
        public System.Windows.Forms.DataGridView cardanGrille;
    }
}

