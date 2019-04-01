using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class Detail
    {
        string ncom;
        string npro;
        int qcom;

        public Detail(string ncom, string npro, int qcom)
        {
            this.ncom = ncom;
            this.npro = npro;
            this.qcom = qcom;
        }
        

        public string NCOM
        {
            get { return ncom; }
            set { ncom = value; }
        }

        public string NPRO
        {
            get { return npro; }
            set { npro = value; }
        }

        public int QCOM
        {
            get { return qcom; }
            set { qcom = value; }
        }


        public override string ToString()
        {
            return "N° commande : " + NCOM + "\nN° Produit : " + NPRO + "\nQuantité commandé : " + QCOM;
        }
    }
}
