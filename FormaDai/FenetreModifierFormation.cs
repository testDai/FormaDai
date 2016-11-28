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
    public partial class FenetreModifierFormation : MetroForm
    {
        DataGridView Datagrid = null;
        Formation Formation { get; set; }
        public FenetreModifierFormation()
        {
            InitializeComponent();
        }

        public FenetreModifierFormation(DataGridView d, Formation f)
        {
            Datagrid = d;
            Formation = f;
            InitializeComponent();
        }

        private void FenetreModifierFormation_Load(object sender, EventArgs e)
        {
            txtIntitule.Text = Formation.Intitule;
            txtDescription.Text = Formation.Description;
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            FormationServices fServ = new FormationServices();
            bool res = fServ.ModifierFormation(Formation.Intitule, txtIntitule.Text, txtDescription.Text);
            Datagrid.DataSource = null;
            Datagrid.DataSource = fServ.GetFormations();
            this.Close();
        }
    }
}
