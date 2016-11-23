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
            PersonneServices pServices = new PersonneServices();
            List<Personne> p = pServices.GetPersonnes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = p;

            FormationServices fServices = new FormationServices();
            List<Formation> l = fServices.GetFormations();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = l;

            ModuleServices mServices = new ModuleServices();
            List<Module> m = mServices.GetModules();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = m;
            
            SessionServices sServices = new SessionServices();
            List<Session> s = sServices.GetSessions();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = s;

            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            //Remplie le label de Bienvenue
            lbBienvenue.Text = lbBienvenue.Text + " " + Personne.Civilite + " " + Personne.Nom + " " + Personne.Prenom;
        }

        private void panelBienvenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFormation_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false; ;
            dataGridView2.Visible = true; ;
            dataGridView3.Visible = false; ;
            dataGridView4.Visible = false;
        }

        private void btModule_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false; ;
            dataGridView2.Visible = false; ;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
        }

        private void btStagiaire_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void btSession_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
        }

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            FenetreConnect fn = new FenetreConnect();
            this.Close();
            fn.Show();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true) // Stagiaire
                new PersonneServices().SupprLigne(dataGridView1);
            else if (dataGridView2.Visible == true) // Formation
                new FormationServices().SupprLigne(dataGridView2);
            else if (dataGridView3.Visible == true) // Module
                new ModuleServices().SupprLigne(dataGridView3);
            else if (dataGridView4.Visible == true) // Sessions
                new SessionServices().SupprLigne(dataGridView4);
        }
    }
}
