using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = openFileDialog.FileName;
            var fileText = System.IO.File.ReadAllText(fileName);
            originalTextBox.Text = fileText;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(decryptedTextBox.Text))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                var filename = saveFileDialog.FileName;

                System.IO.File.WriteAllText(filename, decryptedTextBox.Text);

                MessageBox.Show("Файл сохранен");
            }

            MessageBox.Show("Нечего сохранять");
        }

        byte[] array;
        int[] array1;
        int E, n, d;

        void runButton_Click(object sender, EventArgs e)
        {

            Mathemat model = new Mathemat();

            if (encryptRadioButton.Checked)
            {


                encryptedTextBox.Text = "";
                var str = originalTextBox.Text;
                array = Encoding.GetEncoding(1251).GetBytes(str);

                array1 = new int[array.Length];

                model.Encrypt(out E, out n, out d);
                openKeyTextBox.Text = Convert.ToString(E);
                closedKeyTextBox.Text = Convert.ToString(d);
                for (int i = 0; i < array.Length; i++)
                {
                    array1[i] = (int)BigInteger.ModPow(array[i], E, n);
                    encryptedTextBox.Text += Convert.ToString(array1[i]);
                    encryptedTextBox.Text += " ";
                }
            }

            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (byte)BigInteger.ModPow(array1[i], d, n);
                }

                var str = Encoding.GetEncoding(1251).GetString(array);
                decryptedTextBox.Text = str;
            }


        }
    }
}

