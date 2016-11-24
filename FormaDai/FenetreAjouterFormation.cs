using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace FormaDai
{
    public partial class FenetreAjouterFormation : MetroForm
    {
        public DataGridView Datagrid { get; set; }
        public FenetreAjouterFormation()
        {
            InitializeComponent();
        }


        public FenetreAjouterFormation(DataGridView datagrid)
        {
            Datagrid = datagrid;
            InitializeComponent();
        }

        private void FenetreAjouterFormation_Load(object sender, EventArgs e)
        {

        }


        private void btValider_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Replace(" ", "") != "" && txtIntitule.Text.Replace(" ", "") != "")
            {
                FormationServices f = new FormationServices();
                bool res = f.AjouterFormation(txtIntitule.Text, txtDescription.Text);
                if (res == true)
                    MessageBox.Show("Formation ajoutee avec succes");
                else
                    MessageBox.Show("Erreur lors de la creation de la formation");
                Datagrid.DataSource = null;
                Datagrid.DataSource = f.GetFormations();
                this.Close();   
            }
            else
                MessageBox.Show("Veuillez remplir tout les champs");
        }
    }
}
