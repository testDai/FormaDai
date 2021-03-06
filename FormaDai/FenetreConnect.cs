﻿using System;
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
    public partial class FenetreConnect : MetroForm
    {
        public FenetreConnect()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Replace(" ", "") != "" && txtPassword.Text.Replace(" ", "") != "")
            {
                PersonneServices s = new PersonneServices();
                Personne p = s.GetPersonneByIdPw(txtLogin.Text, txtPassword.Text);
                if (p == null)
                {
                    lbError.Visible = true;
                    txtPassword.Text = "";
                }
                else
                {
                    FenetreAccueil fnAcc = new FenetreAccueil(p);
                    this.Hide();
                    fnAcc.Show();
                }
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs");
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
                lbLogin.Visible = false;
            else
                lbLogin.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lbPassword.Visible = false;
                lbError.Visible = false;
            }
            else
                lbPassword.Visible = true;
        }
    }
}
