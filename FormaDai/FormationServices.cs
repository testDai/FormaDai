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
    }
}
