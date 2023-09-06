using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tantangan1
{
    public partial class Form1 : Form
    {
        private int penambahan(int a, int b)
        {
            return a + b;
        }
        private int pengurangan(int a, int b)
        {
            return a - b;
        }
        private int perkalian(int a, int b)
        {
            return a * b;
        }
        private int pembagian(int a, int b)
        {
            return a / b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            if (int.TryParse(txtNilaiA.Text, out a) && int.TryParse(txtNilaiB.Text, out b))
            {
                string operatorPilihan = ops.SelectedItem.ToString();
                switch (operatorPilihan)
                {
                    case "penambahan":
                        lsHasil.Items.Add(string.Format("{0}", penambahan(a, b)));
                        break;
                    case "pengurangan":
                        lsHasil.Items.Add(string.Format("{0}", pengurangan(a, b)));
                        break;
                    case "perkalian":
                        lsHasil.Items.Add(string.Format("{0}", perkalian(a, b)));
                        break;
                    case "pembagian":
                        if (b != 0)
                            lsHasil.Items.Add(string.Format("{0}", pembagian(a, b)));
                        else
                            MessageBox.Show("Pembagian oleh nol tidak diizinkan.");
                        break;
                }

               
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid.");
            }
        }

        private void lsHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
