using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kim_milyoner_olmak_istemez_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form2 fr = new Form2();
        private void GİRİSBUTON_Click(object sender, EventArgs e)
        {
            string personelnum = "545251";
            string sifre = "abc123";
            if (textBoxPNUM.Text == personelnum && sifre == textBoxSİF.Text)
            {
                MessageBox.Show("Hoşgeldiniz!!!");
                this.Hide();
                fr.Show();
            }
           else 
           {
                MessageBox.Show("Bilgileri doğru girdiğinizden emin olun!");
                textBoxPNUM.Text= null;
                textBoxSİF.Text = null;
           }
        }
    }
}
