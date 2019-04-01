using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLICOM.Common;
using MySql.Data.MySqlClient;

namespace BBDClicom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans la base Clicom.");
            MySqlConnection maConnexion = MaConnexion();
            Deroulement(maConnexion);
            /*
            Clients myclient = new Clients("B000", "KLEINCLAUS", "8, rue des iris",
                "Fegersheim", "B0", 12000.00f);
            ClientServices.AddClient(maConnexion, myclient);
            */
            
            maConnexion.Close();
        }

        public static void Wait()
        {
            Console.WriteLine("Tapez sur entrée pour revenir au menu.");
            string wait = Console.ReadLine();
            Console.Clear();
        }
        public static MySqlConnection MaConnexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FlorentKlein"].ConnectionString;

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }
        public static void AfficheList(List<Clients> maListeClients)
        {

            var listOrd = from cli in maListeClients
                          orderby cli.Nom ascending
                          select cli;

            Console.WriteLine("Affichage clients triés par nom");
            foreach (var cli in listOrd)
            {
                Console.WriteLine(cli.ToString());
            }
        }
        public static void AfficheList(List<Produit> maListeProduits)
        {
            var listOrd = from pro in maListeProduits
                           orderby pro.NPRO ascending
                           select pro;

            Console.WriteLine("Affichage produits triés par nom");
            foreach (var pro in listOrd)
            {
                Console.WriteLine(pro.ToString());
            }
        }
        public static void AfficheList(List<Commande> maListeCommandes)
        {
            var listOrd = from com in maListeCommandes
                           orderby com.NCOM ascending
                           select com;

            Console.WriteLine("Affichage commande triées par ncom");
            foreach (var pro in listOrd)
            {
                Console.WriteLine(pro.ToString());
            }
        }
        public static void AfficheList(List<Detail> maListeDetails)
        {
            var listOrd = from det in maListeDetails
                          orderby det.NCOM ascending
                          select det;

            Console.WriteLine("Affichage detail triés par ncom");
            foreach (var pro in listOrd)
            {
                Console.WriteLine(pro.ToString());
            }
        }
        public static void Deroulement(MySqlConnection maConnexion)
        {
            string enter = "";
            while (enter != "q")
            {
                Console.WriteLine("Tapez 1 pour afficher la liste des produits.");
                Console.WriteLine("Tapez 2 pour afficher la liste des clients.");
                Console.WriteLine("Tapez 3 pour afficher la liste des commandes.");
                Console.WriteLine("Tapez 4 pour afficher la liste des détails.");
                Console.WriteLine("Tapez q pour quitter.");
                enter = Console.ReadLine();
                Console.Clear();
                switch (enter)
                {
                    case "1":
                        {
                            List<Produit> maListeProduits = ProduitServices.GetProduits(maConnexion);
                            AfficheList(maListeProduits);
                            Wait();
                            break;
                        }
                    case "2":
                        {
                            List<Clients> maListeClients = ClientServices.GetClients(maConnexion);
                            AfficheList(maListeClients);
                            Wait();
                            break;
                        }
                    case "3":
                        {
                            List<Commande> maListeCommandes = CommandeServices.GetCommandes(maConnexion);
                            AfficheList(maListeCommandes);
                            Wait();
                            break;
                        }
                    case "4":
                        {
                            List<Detail> maListeDetails = DetailServices.GetDetails(maConnexion);
                            AfficheList(maListeDetails);
                            Wait();
                            break;
                        }

                }

            }
        }
    }
}
