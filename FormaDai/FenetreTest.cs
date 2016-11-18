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
         //string nom = dataGridView1.SelectedCells[1].Value.ToString();
         //   MessageBox.Show(nom);

      }

        private void FenetreTest_Load(object sender, EventArgs e)
        {
            ModuleServices s = new ModuleServices();
            List<Module> list = s.GetModules();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
}
