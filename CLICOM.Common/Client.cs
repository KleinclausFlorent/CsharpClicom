using System;

namespace CLICOM.Common
{
    public class Client
    {
        private string ncli;
        private string nom;
        private string adresse;
        private string localite;
        private string cat;
        private float compte;
        public Client()
        {
        }

        public Client(string ncli, string nom, string adresse, string localite, string cat, float compte)
        {
            this.ncli = ncli;
            this.nom = nom;
            this.adresse = adresse;
            this.localite = localite;
            this.cat = cat;
            this.compte = compte;
        }

        public string Ncli {
            get { return ncli; }
            set { ncli = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Localite
        {
            get { return localite; }
            set { localite = value; }
        }
        public string Cat
        {
            get { return cat; }
            set { cat = value; }
        }
        public float Compte
        {
            get { return compte; }
            set { compte = value; }
        }



    }
}
