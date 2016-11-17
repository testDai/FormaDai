using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormaDai
{
    class SessionServices
    {
        private string chaineConnexion;
        public SessionServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;
        }

        public Session SessionLecture(SqlDataReader reader)
        {
            Session s = new Session();

            s.IdSession = (int)reader["IdSession"];
            s.IdFormation = (int)reader["IdFormation"];
            s.DateDebut = (DateTime)reader["DateDebut"];
            s.DateFin = (DateTime)reader["DateFin"];
            s.DateDebutInscription = (DateTime)reader["DateDebutInscription"];
            return s;
        }

        public Session GetSessionByIdFormation(int id)
        {
            Session s = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Session WHERE IdFormation = @idFormation";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@idFormation", id));
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                            s = SessionLecture(maLecture);
                        maLecture.Close();
                    }
                    maConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return s;
        }

        public List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Session";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        while (maLecture.Read())
                        {
                            Session s = SessionLecture(maLecture);
                            sessions.Add(s);
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
            return sessions;
        }
    }
}
