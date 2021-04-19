using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kim_milyoner_olmak_istemez_v2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string dosyayolu = @"C:\Users\Merve\source\repos\KİTAPLAR.txt";
        private void Form3_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Anı");
            toolStripComboBox1.Items.Add("Biyografi");
            toolStripComboBox1.Items.Add("Deneme");
            toolStripComboBox1.Items.Add("Dünya Klasikleri");
            toolStripComboBox1.Items.Add("Felsefe");
            toolStripComboBox1.Items.Add("Gezi");
            toolStripComboBox1.Items.Add("Kişisel Gelişim");
            toolStripComboBox1.Items.Add("Mektup");
            toolStripComboBox1.Items.Add("Modern Dünya Klasikleri");
            toolStripComboBox1.Items.Add("Öykü");
            toolStripComboBox1.Items.Add("Polisiye");


            string dosyayolu = @"C:\Users\Merve\source\repos\KİTAPLAR.txt";
            StreamReader sr = new StreamReader(dosyayolu);
            Console.WriteLine(sr);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
