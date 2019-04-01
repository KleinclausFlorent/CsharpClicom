using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class CommandeServices
    {
        public static List<Commande> GetCommandes(MySqlConnection connection)
        {
            List<Commande> maListCommandes = new List<Commande>();
            string NCOM, NCLI, DATE;

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clicom.commande;", connection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                NCOM = myReader["NCOM"].ToString();
                NCLI = myReader["NCLI"].ToString();
                DATE = myReader["DATECOM"].ToString();

                maListCommandes.Add(new Commande(NCOM, NCLI, DATE));
            }

            myReader.Close();
            return maListCommandes;
        }
    }
}
