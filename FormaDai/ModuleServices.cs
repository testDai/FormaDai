using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormaDai
{
    class ModuleServices
    {
        private string chaineConnexion;
        public ModuleServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;
        }

        public Module ModuleLecture(SqlDataReader reader)
        {
            Module m = new Module();
            m.IdModule = (int)reader["IdModule"];
            m.Intitule = (string)reader["Intitule"];
            m.Description = (string)reader["Description"];
            m.NbJour = reader["NbJour"] == DBNull.Value ? 0 : (int)reader["NbJour"];
            return m;
        }

        public Module GetModuleByIntitule(string intitule)
        {
            Module m = null;
            using(SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Module WHERE Intitule = @intitule";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@intitule", intitule));
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                            m = ModuleLecture(maLecture);
                        maLecture.Close();
                    }
                    maConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return m;
        }


        public List<Module> GetModules()
        {
            List<Module> modules = new List<Module>();
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
                            Module m = ModuleLecture(maLecture);
                            modules.Add(m);
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
            return modules;
        }

        public bool AjouterModule(string intitule, string description, string nbJour)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "INSERT INTO Module (Intitule, Description, NbJour) VALUES (@intitule, @description, @nbJour)";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramNbJour = new SqlParameter("@nbJour", System.Data.SqlDbType.Int);
                    SqlParameter paramIntit = new SqlParameter("@intitule", System.Data.SqlDbType.VarChar);
                    SqlParameter paramDesc = new SqlParameter("@description", System.Data.SqlDbType.VarChar);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramNbJour.Value = int.Parse(nbJour);
                        paramIntit.Value = intitule;
                        paramDesc.Value = description;
                        maCommande.Parameters.Add(paramNbJour);
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
