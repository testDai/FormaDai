﻿using System;
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
    public partial class FenetreConnect : Form
    {
        public FenetreConnect()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //PersonneServices s = new PersonneServices();
            //Personne p = s.GetPersonneByIdPw(txtLogin.Text, txtPassword.Text);

            //if (p == null)
            //{
            //    MessageBox.Show("Identifiants incorrects");
            //}

            //else
            //{
            //    //MessageBox.Show("Bienvenue " + p.Prenom);
            //    FenetreTest fntr = new FenetreTest();
            //    fntr.ShowDialog();
            //}
            FenetreTest fn = new FenetreTest();
            fn.ShowDialog();

        }
    }
}