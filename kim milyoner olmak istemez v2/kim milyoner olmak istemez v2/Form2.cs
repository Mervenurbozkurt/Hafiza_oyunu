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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          

        }
        Form3 fr3 = new Form3();
        Form4 fr4 = new Form4();
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr3.Show();
        }

        private void KİTAP_EKLE_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr4.Show();
        }
    }
}
