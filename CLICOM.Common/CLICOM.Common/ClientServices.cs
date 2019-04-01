using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class ClientServices
    {
        public static List<Clients> GetClients(MySqlConnection connection)
        {
            List<Clients> maListClients = new List<Clients>();
            string NCLI, NOM, ADRESSE, LOCALITE, CAT;
            float COMPTE;

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clicom.client;", connection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                NCLI = myReader["NCLI"].ToString();
                NOM = myReader["NOM"].ToString();
                ADRESSE = myReader["ADRESSE"].ToString();
                LOCALITE = myReader["LOCALITE"].ToString();
                CAT = myReader["CAT"].ToString();
                COMPTE = float.Parse(myReader["COMPTE"].ToString());

                maListClients.Add(new Clients(NCLI, NOM, ADRESSE, LOCALITE, CAT, COMPTE) );
            }

            myReader.Close();
            return maListClients;
        }

        public static void AddClient(MySqlConnection connection,Clients myClient)
        {
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.CommandText = "INSERT INTO clicom.client VALUES (@NCLI,@NOM,@ADRESSE,@LOCALITE,@CAT,@COMPTE)";
            myCommand.Connection = connection;
            myCommand.Parameters.AddWithValue("@NCLI", myClient.Ncli);
            myCommand.Parameters.AddWithValue("@NOM", myClient.Nom);
            myCommand.Parameters.AddWithValue("@ADRESSE", myClient.Adresse);
            myCommand.Parameters.AddWithValue("@LOCALITE", myClient.Localite);
            myCommand.Parameters.AddWithValue("@CAT", myClient.Cat);
            myCommand.Parameters.AddWithValue("@COMPTE", myClient.Compte);

            myCommand.ExecuteNonQuery();
        }
        
    }
}
