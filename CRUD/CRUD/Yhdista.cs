using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    internal class Yhdista
    {
        private MySqlConnection yhteys = new MySqlConnection(
            "datasource=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=;" +
            "database=opiskelijat;");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
