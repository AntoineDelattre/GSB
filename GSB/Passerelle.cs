// ------------------------------------------
// Nom du fichier : Passerelle.cs
// Objet : classe Passerelle assurant l'alimentation des objets en mémoire
// Auteur :
// Date  : 
// ------------------------------------------

using System;
using System.Data;   // pour ParameterDirection
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using lesClasses;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GSB
{
    static class Passerelle
    {

        private static MySqlConnection cnx;

        // Vérifier les paramètres de connexion et alimente l'objet globale leVisiteur
        static public bool seConnecter(string login, string mdp, out string message) {

            string chaineConnexion = $"Data Source=localhost;Database=gsb; User Id={login}; Password={mdp}";
            cnx = new MySqlConnection(chaineConnexion);
            bool ok = true;
            message = null;

            try {
                // etablit une connexion saut si une connexion existe déjà 
                cnx.Open();

            } catch (MySqlException e) {
                ok = false;
                if (e.Message.Contains("Accès refusé")) {
                    message = "Vos identifiants sont incorrects.";
                } else {
                    message = "Problème lors de la tentative de connexion au serveur.\n";
                    message += "Prière de contacter le service informatique";
                }
            } catch (Exception e) {
                message = e.ToString();
                ok = false;
            }

            if (ok) {
                // récupération des informations sur le visiteurs depuis la vue leVisiteur           
                MySqlCommand cmd = new MySqlCommand("Select nomPrenom from leVisiteur;", cnx);
                try {
                    Globale.nomVisiteur = cmd.ExecuteScalar().ToString();
                } catch (MySqlException e) {
                    message = "Erreur lors de la récupération de vos paramètres \n";
                    message += "Veuillez contacter le service informatique\n";
                    ok = false;
                }
            }
            if (ok) message = "Visiteur authentifié";
            return ok;
        }

        // se déconnecter
        static public void seDeConnecter() => cnx.Close();


        // chargement des données de la base dans les différentes collections statiques de la classe Globale 
        // dans cette méthode pas de bloc try catch car aucune erreur imprévisible en production ne doit se produire
        // en cas d'erreur en développement il faut laisser faire le debogueur de VS qui va signaler la ligne en erreur
        // le chargement des données concernant tous les visiteurs (médicament, type praticien, specialite, motif) ne doit être fait qu'une fois
        // si elles sont déja chargées on ne les recherche pas.
        // le chargement des données spécifiques au visiteur connecté doit se faire à chaque fois en vidant les anciennes données 
        static public void chargerDonnees()
        {
            // Chargement des données
            string sql = "select id, libelle from typepraticien";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            MySqlDataReader curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                string id = curseur["id"].ToString();
                string libelle = curseur["libelle"].ToString();
                Globale.lesTypes.Add(new TypePraticien(id, libelle));
            }
            curseur.Close();
            
            cmd.CommandText = "select id, libelle from specialite";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                string id = curseur["id"].ToString();
                string libelle = curseur["libelle"].ToString();
                Globale.lesSpecialites.Add(new Specialite(id, libelle));
            }
            curseur.Close();

            cmd.CommandText = "select id, libelle from motif";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                int id = curseur.GetInt32(0);
                string libelle = curseur["libelle"].ToString();
                Globale.lesMotifs.Add(new Motif(id, libelle));
            }
            curseur.Close();

            cmd.CommandText = "select nom, codePostal from mesVilles";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                string nom = curseur["nom"].ToString();
                string codePostal = curseur["codePostal"].ToString();
                Globale.mesVilles.Add(new Ville(nom, codePostal));
            }
            curseur.Close();

            cmd.CommandText = "select id, libelle from famille";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                string id = curseur["id"].ToString();
                string libelle = curseur["libelle"].ToString();
                Famille f = new Famille(id,libelle);
                Globale.lesFamilles.Add(id, f);
            }
            curseur.Close();

            cmd.CommandText = "select id, nom, composition, effets, contreIndication, idFamille from medicament";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                string id = curseur["id"].ToString();
                string nom = curseur["nom"].ToString();
                string effet = curseur["effets"].ToString();
                string composition = curseur["composition"].ToString();
                string contreIndication = curseur["contreIndication"].ToString();
                string idFamille = curseur["idFamille"].ToString();
                Famille f = Globale.lesFamilles[idFamille];
                Globale.lesMedicaments.Add(new Medicament(id, nom, composition, effet, contreIndication, f));
            }
            curseur.Close();

            List<Praticien> lesPraticiens = new List<Praticien>();
            cmd.CommandText = "select id, nom, prenom, rue, codePostal, ville, telephone, email, idType, idSpecialite from praticien where id in (Select id from mesPraticiens)";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                int id = curseur.GetInt32(0);
                string nom = curseur["nom"].ToString();
                string prenom = curseur["prenom"].ToString();
                string rue = curseur["rue"].ToString();
                string codePostal = curseur["codePostal"].ToString();
                string ville = curseur["ville"].ToString();
                string email = curseur["email"].ToString();
                string telephone = curseur["telephone"].ToString();
                string idType = curseur["idType"].ToString();
                string idSpecialite = curseur["idSpecialite"].ToString();

                TypePraticien t = Globale.lesTypes.Find(x => x.Id == idType);
                Specialite s = Globale.lesSpecialites.Find(x => x.Id == idSpecialite);

                Globale.mesPraticiens.Add(new Praticien(id, nom, prenom, rue, codePostal, ville, email, telephone, t, s));
            }
            curseur.Close();

            cmd.CommandText = "select id, bilan, premierMedicament, secondMedicament, idPraticien, idMotif, dateEtHeure from mesVisites";
            curseur = cmd.ExecuteReader();
            while (curseur.Read())
            {
                int id = curseur.GetInt32(0);
                int idPraticien = curseur.GetInt32(4);
                int idMotif = curseur.GetInt32(5);
                string bilan = curseur["bilan"].ToString();
                string premierMedicament = curseur["premierMedicament"].ToString();
                string secondMedicament = curseur["secondMedicament"].ToString();
                Medicament premierM = Globale.lesMedicaments.Find(x => x.Id == premierMedicament);
                Medicament secondM = Globale.lesMedicaments.Find(x => x.Id == secondMedicament);
                Praticien lePraticien = Globale.mesPraticiens.Find(x => x.Id == idPraticien);
                Motif leMotif = Globale.lesMotifs.Find(x => x.Id == idMotif);
                DateTime dateEtHeure = curseur.GetDateTime(6);
                
                Globale.mesVisites.Add(new Visite(id, lePraticien, leMotif, dateEtHeure));
                Visite v = new Visite(id, lePraticien, leMotif, dateEtHeure);
                v.enregistrerBilan(bilan, premierM, secondM);
            }
            curseur.Close();
            
            // fermer la connexion
            cnx.Close();
        }


    /// <summary>
    ///     Ajout d'une nouvelle visite
    /// </summary>
    /// <param name="idPraticien"></param>
    /// <param name="idMotif"></param>
    /// <param name="uneDate"></param>
    /// <param name="uneHeure"></param>
    /// <param name="message"></param>
    /// <returns>identifiant de la nouvelle visite ou 0 si erreur lors de la création</returns>
    static public int ajouterRendezVous(int idPraticien, int idMotif, DateTime uneDate, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "ajouterRendezVous",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("idPraticien", idPraticien);
            cmd.Parameters.AddWithValue("idMotif", idMotif);
            cmd.Parameters.AddWithValue("dateEtHeure", uneDate);
            cmd.Parameters.Add("idVisite", MySqlDbType.Int32);
            cmd.Parameters["idVisite"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int idVisite = (Int32)cmd.Parameters["idVisite"].Value;

            message = string.Empty;
            return idVisite;
        }

        /// <summary>
        ///     Supprime un rendez-vous
        /// </summary>
        /// <param name="idVisite"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        static public bool supprimerRendezVous(int idVisite, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "supprimerRendezVous",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("idVisite", idVisite);
            cmd.ExecuteNonQuery();

            message = string.Empty;
            return true;
        }

        static public bool modifierRendezVous(int idVisite, DateTime uneDateEtHeure, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "modifierRendezVous",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("idVisite", idVisite);
            cmd.Parameters.AddWithValue("uneDateEtHeure", uneDateEtHeure);
            cmd.ExecuteNonQuery();

            message = string.Empty;
            return true;
        }

        static public bool enregistrerBilan(Visite uneVisite, out string message)
        {
            MySqlTransaction uneTransaction = cnx.BeginTransaction();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "enregistrerBilanVisite",
                CommandType = CommandType.StoredProcedure,
                Transaction = uneTransaction
            };            
            try
            {
                cmd.Parameters.AddWithValue("bilan", uneVisite.Bilan);
                cmd.Parameters.AddWithValue("premierMedicament", uneVisite.PremierMedicament);
                cmd.Parameters.AddWithValue("secondMedicament", uneVisite.SecondMedicament);
                cmd.Parameters.AddWithValue("id", uneVisite.Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "ajouterEchantillon";
                Random rnd = new Random();
                rnd.Next(0, 10);
                cmd.Parameters.AddWithValue("id", uneVisite.Id);
                cmd.Parameters.AddWithValue("idMedicament", uneVisite.PremierMedicament);
                cmd.Parameters.AddWithValue("quantite", rnd);
                cmd.ExecuteNonQuery();
                uneTransaction.Commit();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                uneTransaction.Rollback();
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            cnx.Close();


            message = string.Empty;
            return false;
        }


        static public int ajouterPraticien(string nom, string prenom, string rue, string codePostal, string ville, string telephone, string email, string unType, string uneSpecialite, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "ajouterPraticien",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("nom", nom);
            cmd.Parameters.AddWithValue("prenom", prenom);
            cmd.Parameters.AddWithValue("rue", rue);
            cmd.Parameters.AddWithValue("codePostal", codePostal);
            cmd.Parameters.AddWithValue("ville", ville);
            cmd.Parameters.AddWithValue("telephone", telephone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("unType", unType);
            cmd.Parameters.AddWithValue("uneSpecialite", uneSpecialite);
            cmd.Parameters.Add("idPraticien", MySqlDbType.Int32);
            cmd.Parameters["idPraticien"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int idPraticien = (Int32)cmd.Parameters["idPraticien"].Value;

            message = string.Empty;            
            return idPraticien;
        }


        static public bool modifierPraticien(int id, string nom, string prenom, string rue, string codePostal, string ville, string telephone, string email, string unType, string uneSpecialite, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "modifierPraticien",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("nom", nom);
            cmd.Parameters.AddWithValue("prenom", prenom);
            cmd.Parameters.AddWithValue("rue", rue);
            cmd.Parameters.AddWithValue("codePostal", codePostal);
            cmd.Parameters.AddWithValue("ville", ville);
            cmd.Parameters.AddWithValue("telephone", telephone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("unType", unType);
            cmd.Parameters.AddWithValue("uneSpecialite", uneSpecialite);
            cmd.ExecuteNonQuery();
            
            message = string.Empty;
            return true;
        }

        static public bool supprimerPraticien(int id, out string message)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = cnx,
                CommandText = "supprimerPraticien",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();

            message = string.Empty;
            return true;
        }

    }
}
