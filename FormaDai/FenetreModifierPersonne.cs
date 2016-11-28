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
    public partial class FenetreModifierPersonne : MetroForm
    {
        Personne Personne { get; set; }
        Personne Cible { get; set; }
        DataGridView Datagrid { get; set; }
        public FenetreModifierPersonne()
        {
            InitializeComponent();
        }

        public FenetreModifierPersonne(Personne p, Personne c, DataGridView d)
        {
            Personne = p;
            Cible = c;
            Datagrid = d;
            InitializeComponent();
        }

        private void FenetreModifierPersonne_Load(object sender, EventArgs e)
        {
            if (Personne.EstAdmin == true)
            {
                lbAdmin.Visible = true;
                cbAdmin.Visible = true;
            }
            txtNom.Text = Cible.Nom;
            txtPrenom.Text = Cible.Prenom;
            txtMail.Text = Cible.Mail;
            txtAdresse.Text = Cible.Adresse;
            txtVille.Text = Cible.Ville;
            txtTelephone.Text = Cible.Telephone;
            txtCodePostal.Text = Cible.CodePostal;
            cbCivilite.Text = Cible.Civilite;
            cbAdmin.Text = Cible.EstAdmin.ToString();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            PersonneServices pServ = new PersonneServices();
            bool res = pServ.ModifierPersonne(Cible.Mail, txtNom.Text, txtPrenom.Text, txtMail.Text, cbCivilite.Text, txtAdresse.Text, txtCodePostal.Text, txtVille.Text, Cible.Password, txtTelephone.Text);
            if (res == false)
                MessageBox.Show("Erreur lors de la modification");
            Datagrid.DataSource = null;
            Datagrid.DataSource = pServ.GetPersonnes();
            this.Close();
        }
    }
}
