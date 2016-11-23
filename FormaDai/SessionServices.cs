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

        public bool AjouterSession(int idFormation, DateTime dateDebut, DateTime dateFin, DateTime dateDebutInscription)
        {
            using(SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "INSERT INTO Session (IdFormation, DateDebut, DateFin, DateDebutInscription) VALUES (@idFormation, @dateDebut, @dateFin, @dateDebutInscription)";
                {
                    try
                    {
                        maConnexion.Open();
                        using(SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                        {
                            SqlParameter paramIdFormation = new SqlParameter("@idFormation", System.Data.SqlDbType.Int);
                            SqlParameter paramDateDebut = new SqlParameter("@dateDebut", System.Data.SqlDbType.DateTime);
                            SqlParameter paramDateFin = new SqlParameter("@dateFin", System.Data.SqlDbType.DateTime);
                            SqlParameter paramDateDebutInsc = new SqlParameter("@dateDebutInscription", System.Data.SqlDbType.DateTime);

                            paramIdFormation.Value = idFormation;
                            paramDateDebut.Value = dateDebut;
                            paramDateFin.Value = dateFin;
                            paramDateDebutInsc.Value = dateDebutInscription;

                            maCommande.Parameters.Add(paramIdFormation);
                            maCommande.Parameters.Add(paramDateDebut);
                            maCommande.Parameters.Add(paramDateFin);
                            maCommande.Parameters.Add(paramDateDebutInsc);

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

        public bool ModifierSession(int idSession, int idFormation, DateTime dateDebut, DateTime dateFin, DateTime dateDebutInscription)
        {
            using(SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "UPDATE Session SET IdFormation = @idFormation, DateDebut = @dateDebut, DateFin = @dateFin, DateDebutInscription = @dateDebutInscription WHERE IdSession = @idSession";
                try
                {
                    maConnexion.Open();
                    using(SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlParameter paramIdSession = new SqlParameter("@idSession", System.Data.SqlDbType.Int);
                        SqlParameter paramIdFormation = new SqlParameter("@idFormation", System.Data.SqlDbType.Int);
                        SqlParameter paramDateDebut = new SqlParameter("@dateDebut", System.Data.SqlDbType.DateTime);
                        SqlParameter paramDateFin = new SqlParameter("@dateFin", System.Data.SqlDbType.DateTime);
                        SqlParameter paramDateDebutInsc = new SqlParameter("@dateDebutInscription", System.Data.SqlDbType.DateTime);

                        paramIdSession.Value = idSession;
                        paramIdFormation.Value = idFormation;
                        paramDateDebut.Value = dateDebut;
                        paramDateFin.Value = dateFin;
                        paramDateDebutInsc.Value = dateDebutInscription;

                        maCommande.Parameters.Add(paramIdSession);
                        maCommande.Parameters.Add(paramIdFormation);
                        maCommande.Parameters.Add(paramDateDebut);
                        maCommande.Parameters.Add(paramDateFin);
                        maCommande.Parameters.Add(paramDateDebutInsc);

                        maCommande.ExecuteNonQuery();
                    }
                    maConnexion.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public bool SupprSession(int idSession)
        {
            using(SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "DELETE FROM Session WHERE IdSession = @idSession";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlParameter paramIdSession = new SqlParameter("@IdSession", System.Data.SqlDbType.Int);

                        paramIdSession.Value = idSession;

                        maCommande.Parameters.Add(paramIdSession);

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

        public void SupprLigne(DataGridView dataGridView4)
        {
            try
            {
                SessionServices sServ = new SessionServices();
                int id = int.Parse(dataGridView4.SelectedCells[0].Value.ToString());
                if (sServ.SupprSession(id) == true)
                {
                    MessageBox.Show("Module supprime avec succes");
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = sServ.GetSessions();
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
