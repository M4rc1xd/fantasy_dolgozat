using fantasy_dolgozat;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fantasyDolgozat
{
    class SzornyAdatbazis
    {
        public List<szorny> Feltolt()
        {
            string connectionString = "server=localhost;database=fantasyBestariumdb;uid=root;pwd=;port=3306;SslMode=None;";

            List<szorny> szornyek = new List<szorny>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * from szornyek";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("Id");
                                string nev = reader.GetString("Nev");
                                int veszelyessegiSzint = reader.GetInt32("VeszelyessegiSzint");
                                string elohely = reader.GetString("Elohely");
                                string foGyengeseg = reader.GetString("FoGyengeseg");
                                string leggyakoribbZsakmany = reader.GetString("LeggyakoribbZsakmany");
                                bool veszelyesE = reader.GetBoolean("VeszelyesE");
                                szornyek.Add(new szorny(
                                    id,
                                    nev,
                                    veszelyessegiSzint,
                                    elohely,
                                    foGyengeseg,
                                    leggyakoribbZsakmany,
                                    veszelyesE));
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error connecting to MySQL: {ex.Message}");
                }
            }

            return szornyek;
        }
    }
}