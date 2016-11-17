using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaDai
{
    public partial class FenetreTest : Form
    {
        public FenetreTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonneServices ms = new PersonneServices();
            bool res = ms.AjouterPersonne(txt1.Text, txt2.Text, txt3.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, false);
            if (res == true)
                MessageBox.Show("YEAH");
            else
                MessageBox.Show("ERROR");
        }
    }
}
