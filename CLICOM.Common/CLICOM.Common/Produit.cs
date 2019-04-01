using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class Produit
    {
        string npro;
        string libelle;
        int prix;
        int qstock;

        public Produit(string npro, string libelle, int prix, int qstock)
        {
            this.npro = npro;
            this.libelle = libelle;
            this.prix = prix;
            this.qstock = qstock;
        }

        public string NPRO
        {
            get { return npro; }
            set { npro = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public int QStock
        {
            get { return qstock; }
            set { qstock = value; }
        }

        public override string ToString()
        {
            return "N° produit : " + NPRO + "\nLibelle : " + Libelle + "\nPrix : " + Prix + "\nQuantité en stock : " + QStock;
        }
    }
}
