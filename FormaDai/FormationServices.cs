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
                string maRequete = "UPDATE Formation SET Intitule=@newIntitule, Description=@newDescription WHERE Intitule=intitule";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramIntit = new SqlParameter("@intitule", System.Data.SqlDbType.VarChar);
                    SqlParameter paramDesc = new SqlParameter("@description", System.Data.SqlDbType.VarChar);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramIntit.Value = newIntitule;
                        paramDesc.Value = newDescription;
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
    }
}
