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
    class PersonneServices
    {
        private string chaineConnexion;
        public PersonneServices()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["Forma"].ConnectionString;

        }
        public Personne PersonneLecture(SqlDataReader reader)
        {
            Personne p = new FormaDai.Personne();
            p.IdPersonne = (int)reader["IdPersonne"];
            p.Nom = (string)reader["Nom"];
            p.Prenom = (string)reader["Prenom"];
            p.Civilite = (string)reader["Civilite"];
            p.Mail = (string)reader["Mail"];
            p.Adresse = (string)reader["Adresse"];
            p.CodePostal = (string)reader["CodePostal"];
            p.Ville = (string)reader["Ville"];
            p.Password = (string)reader["Password"];
            p.Telephone = (string)reader["Telephone"];
            p.Photo = reader["Photo"] == DBNull.Value ? null : (string)reader["Photo"]; //attention a ne pas oublier si un champ peut être null
            p.EstAdmin = (bool)reader["EstAdmin"];
            return p;
        }

        public List<Personne> GetPersonnes()
        {
            List<Personne> personnes = new List<Personne>();
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Personne";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        while (maLecture.Read())
                        {
                            Personne p = new Personne();
                            p = PersonneLecture(maLecture);
                            personnes.Add(p);
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
            return personnes;
        }

        public Personne GetPersonneByIdPw(string mail, string pass)
        {
            Personne p = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Personne WHERE Mail = @mail AND Password = @pass";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@mail", mail));
                        maCommande.Parameters.Add(new SqlParameter("@pass", pass));
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        if (maLecture.Read())
                        {
                            p = PersonneLecture(maLecture);
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
            return p;
        }
        //Methode pour afficher les personnes qui ont candidaté à une session. Ni la requête SQL ni la méthode n'ont été vérifiées.
        public List<Personne> GetPersonneBySession(int idSession)
        {
            List<Personne> sessionPersonnes = null;
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "SELECT * FROM Personne INNER JOIN Candidature ON IdPersonne = IdPersonne WHERE IdSession = @idSession";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@idSession", idSession));
                        SqlDataReader maLecture = maCommande.ExecuteReader();
                        while (maLecture.Read())
                        {
                            Personne p = PersonneLecture(maLecture);
                            sessionPersonnes.Add(p);
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
            return sessionPersonnes;
        }

        public bool AjouterPersonne(string nom, string prenom, string mail, string civilite, string adresse, string codePostal, string ville, string password, string telephone, bool estAdmin)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "INSERT INTO Personne (Nom, Prenom, Mail, Civilite, Adresse, CodePostal, Ville, Password, Telephone, EstAdmin) VALUES (@nom, @prenom, @mail, @civilite, @adresse, @codePostal, @ville, @password, @telephone, @estAdmin)";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramNom = new SqlParameter("@nom", System.Data.SqlDbType.VarChar);
                    SqlParameter paramPrenom = new SqlParameter("@prenom", System.Data.SqlDbType.VarChar);
                    SqlParameter paramMail = new SqlParameter("@mail", System.Data.SqlDbType.VarChar);
                    SqlParameter paramCivilite = new SqlParameter("@civilite", System.Data.SqlDbType.VarChar);
                    SqlParameter paramAdresse = new SqlParameter("@adresse", System.Data.SqlDbType.VarChar);
                    SqlParameter paramCodePostal = new SqlParameter("@codePostal", System.Data.SqlDbType.VarChar);
                    SqlParameter paramVille = new SqlParameter("@ville", System.Data.SqlDbType.VarChar);
                    SqlParameter paramPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar);
                    SqlParameter paramTelephone = new SqlParameter("@telephone", System.Data.SqlDbType.VarChar);
                    SqlParameter paramEstAdmin = new SqlParameter("@estAdmin", System.Data.SqlDbType.Bit);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramNom.Value = nom;
                        paramPrenom.Value = prenom;
                        paramMail.Value = mail;
                        paramCivilite.Value = civilite;
                        paramAdresse.Value = adresse;
                        paramCodePostal.Value = codePostal;
                        paramVille.Value = ville;
                        paramPassword.Value = password;
                        paramTelephone.Value = telephone;
                        paramEstAdmin.Value = estAdmin;

                        maCommande.Parameters.Add(paramNom);
                        maCommande.Parameters.Add(paramPrenom);
                        maCommande.Parameters.Add(paramMail);
                        maCommande.Parameters.Add(paramCivilite);
                        maCommande.Parameters.Add(paramAdresse);
                        maCommande.Parameters.Add(paramCodePostal);
                        maCommande.Parameters.Add(paramVille);
                        maCommande.Parameters.Add(paramPassword);
                        maCommande.Parameters.Add(paramTelephone);
                        maCommande.Parameters.Add(paramEstAdmin);
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
        public bool ModifierPersonne(string email, string newNom, string newPrenom, string newMail, string newCivilite, string newAdresse, string newCodePostal, string newVille, string newPassword, string newTelephone)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "UPDATE Personne SET Nom = @nom, Prenom = @prenom, Mail = @mail, Civilite = @civilite, Adresse = @adresse, CodePostal = @codePostal, Ville = @ville, Password = @password, Telephone = @telephone WHERE Email = email";
                try
                {
                    maConnexion.Open();
                    SqlParameter paramNom = new SqlParameter("@nom", System.Data.SqlDbType.VarChar);
                    SqlParameter paramPrenom = new SqlParameter("@prenom", System.Data.SqlDbType.VarChar);
                    SqlParameter paramMail = new SqlParameter("@mail", System.Data.SqlDbType.VarChar);
                    SqlParameter paramCivilite = new SqlParameter("@civilite", System.Data.SqlDbType.VarChar);
                    SqlParameter paramAdresse = new SqlParameter("@adresse", System.Data.SqlDbType.VarChar);
                    SqlParameter paramCodePostal = new SqlParameter("@codePostal", System.Data.SqlDbType.VarChar);
                    SqlParameter paramVille = new SqlParameter("@ville", System.Data.SqlDbType.VarChar);
                    SqlParameter paramPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar);
                    SqlParameter paramTelephone = new SqlParameter("@telephone", System.Data.SqlDbType.VarChar);
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        paramNom.Value = newNom;
                        paramPrenom.Value = newPrenom;
                        paramMail.Value = newMail;
                        paramCivilite.Value = newCivilite;
                        paramAdresse.Value = newAdresse;
                        paramCodePostal.Value = newCodePostal;
                        paramVille.Value = newVille;
                        paramPassword.Value = newPassword;
                        paramTelephone.Value = newTelephone;

                        maCommande.Parameters.Add(paramNom);
                        maCommande.Parameters.Add(paramPrenom);
                        maCommande.Parameters.Add(paramMail);
                        maCommande.Parameters.Add(paramCivilite);
                        maCommande.Parameters.Add(paramAdresse);
                        maCommande.Parameters.Add(paramCodePostal);
                        maCommande.Parameters.Add(paramVille);
                        maCommande.Parameters.Add(paramPassword);
                        maCommande.Parameters.Add(paramTelephone);
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

        public bool SupprPersonne(string nom, string mail)
        {
            using (SqlConnection maConnexion = new SqlConnection(chaineConnexion))
            {
                string maRequete = "DELETE * FROM Personne WHERE Nom = @nom AND Mail = @mail";
                try
                {
                    maConnexion.Open();
                    using (SqlCommand maCommande = new SqlCommand(maRequete, maConnexion))
                    {
                        maCommande.Parameters.Add(new SqlParameter("@nom", nom));
                        maCommande.Parameters.Add(new SqlParameter("@mail", mail));
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
