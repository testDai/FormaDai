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
    public partial class FenetreAccueil : MetroForm
    {
        private Personne Personne {get; set; }
        public FenetreAccueil()
        {
            InitializeComponent();
        }

        public FenetreAccueil(Personne p)
        {
            Personne = p;
            InitializeComponent();
        }


        private void FenetreAccueil_Load(object sender, EventArgs e)
        {
            // Remplie le dataGrid avec les Personnes
            PersonneServices services = new PersonneServices();
            List<Personne> p = services.GetPersonnes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = p;

            //Remplie le label de Bienvenue
            lbBienvenue.Text = lbBienvenue.Text + " " + Personne.Civilite + " " + Personne.Nom + " " + Personne.Prenom;
        }

        private void panelBienvenue_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
