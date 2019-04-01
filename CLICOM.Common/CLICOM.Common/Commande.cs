using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class Commande
    {
        string ncom;
        string ncli;
        string date;

        public Commande(string ncom, string ncli, string date)
        {
            this.ncom = ncom;
            this.ncli = ncli;
            this.date = date;
        }

        public string NCOM
        {
            get { return ncom; }
            set { ncom = value; }
        }

        public string NCLI
        {
            get { return ncli; }
            set { ncli = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        

        public override string ToString()
        {
            return "N° commande : " + NCOM + "\nN° Client : " + NCLI + "\nDate : " + Date;
        }
    }
}
