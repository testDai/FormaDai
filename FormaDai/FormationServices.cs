using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace FormaDai
{
    class FormationServices
    {
        private string chaineConnexion;
        public FormationServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;
        }

        public Formation FormationLecture(SqlDataReader reader)
        {
            Formation f = new Formation();
            f.IdFormation = (int)reader["IdFormation"];
            f.Intitule = (string)reader["Intitule"];
            f.Description = (string)reader["Description"];
            return f;
        }

        public Formation GetFormationByIntitule(string intitule)
        {
            Formation f = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Formation WHERE Intitule = @intitule";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@intitule", intitule));
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                            f = FormationLecture(maLecture);
                        maLecture.Close();
                    }
                    maConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return f;
        }

        public List<Formation> GetFormations()
        {
            List<Formation> formations = new List<Formation>();
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Formation";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        while (maLecture.Read())
                        {
                            Formation f = FormationLecture(maLecture);
                            formations.Add(f);
                        }
                        maLecture.Close();
                    }
                    maConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return formations;
        }

        public bool AjouterFormation(string intitule, string description)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "INSERT INTO Formation (Intitule, Description) VALUES (@intitule, @description)";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramIntit = new SqlParameter("@intitule", System.Data.SqlDbType.VarChar);
                    SqlParameter paramDesc = new SqlParameter("@description", System.Data.SqlDbType.VarChar);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramIntit.Value = intitule;
                        paramDesc.Value = description;
                        maCommande.Parameters.Add(paramIntit);
                        maCommande.Parameters.Add(paramDesc);
                        maCommande.ExecuteNonQuery();
                    }
                    maConnexion.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool ModifierFormation(string intitule, string newIntitule, string newDescription)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "UPDATE Formation SET Intitule=@intitule, Description=@description WHERE Intitule = @oldIntitule";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramIntit = new SqlParameter("@intitule", System.Data.SqlDbType.VarChar);
                    SqlParameter paramDesc = new SqlParameter("@description", System.Data.SqlDbType.VarChar);
                    SqlParameter paramOldIntit = new SqlParameter("@oldIntitule", System.Data.SqlDbType.VarChar);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramIntit.Value = newIntitule;
                        paramDesc.Value = newDescription;
                        paramOldIntit.Value = intitule;
                        maCommande.Parameters.Add(paramIntit);
                        maCommande.Parameters.Add(paramDesc);
                        maCommande.Parameters.Add(paramOldIntit);
                        maCommande.ExecuteNonQuery();
                    }
                    maConnexion.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool SupprFormation(string intitule)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "DELETE FROM Formation WHERE Intitule=@intitule";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@intitule", intitule));
                        maCommande.ExecuteNonQuery();
                    }
                    maConnexion.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public void SupprLigne(DataGridView dataGridView2)
        {
            try
            {
                FormationServices fServ = new FormationServices();
                string intitule = dataGridView2.SelectedCells[0].Value.ToString();
                if (fServ.SupprFormation(intitule) == true)
                {
                    MessageBox.Show("Formation supprimee avec succes");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = fServ.GetFormations();
                }
                else
                    MessageBox.Show("Erreur lors de la suppression");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez selectionner la ligne a supprimer");
            }
        }
    }
}
