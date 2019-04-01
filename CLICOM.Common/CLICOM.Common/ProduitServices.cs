using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class ProduitServices
    {
        public static List<Produit> GetProduits(MySqlConnection connection)
        {
            List<Produit> maListProduits = new List<Produit>();
            string NPRO, LIBELLE;
            int PRIX, QSTOCK;

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clicom.produit;", connection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                NPRO = myReader["NPRO"].ToString();
                LIBELLE = myReader["LIBELLE"].ToString();
                PRIX = int.Parse(myReader["PRIX"].ToString());
                QSTOCK = int.Parse(myReader["QSTOCK"].ToString());

                maListProduits.Add(new Produit(NPRO, LIBELLE, PRIX, QSTOCK));
            }

            myReader.Close();
            
            return maListProduits;
        }
    }
}
