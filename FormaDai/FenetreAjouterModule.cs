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
    public partial class FenetreAjouterModule : MetroForm
    {
        public DataGridView Datagrid { get; set; }
        public Module Module { get; set; }
        public FenetreAjouterModule()
        {
            InitializeComponent();
        }

        // Utile pour ajouter le module
        public FenetreAjouterModule(DataGridView d)
        {
            Datagrid = d;
            InitializeComponent();
        }

        // Utile pour modifier le module
        public FenetreAjouterModule(DataGridView d, Module m)
        {
            Datagrid = d;
            Module = m;
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Replace(" ", "") != "" && txtIntitule.Text.Replace(" ", "") != "" && txtNbJour.Text.Replace(" ", "") != "")
            {
                ModuleServices f = new ModuleServices();
                bool res = f.AjouterModule(txtIntitule.Text, txtDescription.Text, txtNbJour.Text);
                if (res == true)
                    MessageBox.Show("Module ajoute avec succes");
                else
                    MessageBox.Show("Erreur lors de la creation du module");
                Datagrid.DataSource = null;
                Datagrid.DataSource = f.GetModules();
                this.Close();   
            }
            else
                MessageBox.Show("Veuillez remplir tout les champs");
        }

        private void FenetreAjouterModule_Load(object sender, EventArgs e)
        {
            if (Module != null)
            {
                lbAjouterModule.Text = "Modification du module";
                Name = "FenetreModifierModule";
                txtIntitule.Text = Module.Intitule;
                txtDescription.Text = Module.Description;
                txtNbJour.Text = Module.NbJour.ToString();
            }
        }
    }
}
