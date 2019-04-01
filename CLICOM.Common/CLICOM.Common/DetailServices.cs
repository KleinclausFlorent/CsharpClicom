using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICOM.Common
{
    public class DetailServices
    {
        public static List<Detail> GetDetails(MySqlConnection connection)
        {
            List<Detail> maListDetails = new List<Detail>();
            string NCOM, NPRO;
            int QCOM;

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clicom.detail;", connection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                NCOM = myReader["NCOM"].ToString();
                NPRO = myReader["NPRO"].ToString();
                QCOM = int.Parse(myReader["QCOM"].ToString());

                maListDetails.Add(new Detail(NCOM, NPRO, QCOM));
            }

            myReader.Close();
            return maListDetails;
        }
    }
}
