using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_absensiswacoding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama: " + textBox1.Text + "\nNis: " + textBox2.Text + "\nKelas: " + textBox3.Text + "\nJurusan: " + textBox4.Text);
        }
    }
}
