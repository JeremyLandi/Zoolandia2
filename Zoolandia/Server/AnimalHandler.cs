using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class AnimalHandler
    {
        #region sqlConnection
        private SqlConnection _sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
           "\"C:\\Users\\Jeremy\\Documents\\Visual Studio 2015\\Projects\\Zoolandia\\Zoolandia\\ZooData.mdf\";Integrated Security=True");
        #endregion


        public AnimalHandler()
        {
        }

        public string getAnimal(string IdAnimal)
        {
            string response = "";

            string query = @"
				SELECT 
				  a.IdAnimal,
				  a.Name, 
				  h.Name HabitatName,
				  ht.Name HabitatType,
				  s.CommonName,
				  s.ScientificName
				FROM Animal a
				INNER JOIN Species s ON a.IdSpecies = s.IdSpecies
				INNER JOIN Habitat h ON h.IdHabitat = a.IdHabitat
				INNER JOIN HabitatType ht on ht.IdHabitatType = h.IdHabitatType
				WHERE a.IdAnimal = 
				" + IdAnimal;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            //using will clean up everything... open and close connections
            //Read the database. While there is items in database build customer
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response += "<div class=\"animal animal-id-" + reader[0] + "\">";
                    response += "<h2>" + reader[1] + "</h2>";
                    response += "<div><a href='/animals/" + reader[0] + "'>" + reader[5] + "</a></div>";
                    response += "<div>Lives in the " + reader[2] + " (" + reader[3] + " type) habitat</div>";
                    response += "</div>";
                }
                response += "<div><a href='/animals'>Home</a></div>";
                Console.WriteLine(response);

                _sqlConnection.Close();
                return response;
            }
        }


        public string getAllAnimals()
        {
            string response = "";

            const string query = @"
				SELECT 
				  a.IdAnimal,
				  a.Name, 
				  h.Name HabitatName,
				  ht.Name HabitatType,
				  s.CommonName,
				  s.ScientificName
				FROM Animal a
				INNER JOIN Species s ON a.IdSpecies = s.IdSpecies
				INNER JOIN Habitat h ON h.IdHabitat = a.IdHabitat
				INNER JOIN HabitatType ht on ht.IdHabitatType = h.IdHabitatType
				";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            //using will clean up everything... open and close connections
            //Read the database. While there is items in database build customer
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response += "<div class=\"animal animal-id-" + reader[0] + "\">";
                    response += "<h2>" + reader[1] + "</h2>";
                    response += "<div><a href='/animals/" + reader[0] + "'>" + reader[5] + "</a></div>";
                    response += "<div>Lives in the " + reader[2] + " (" + reader[3] + " type) habitat</div>";
                    response += "</div>";
                }
                Console.WriteLine(response);

                _sqlConnection.Close();
                return response;
            }
        }
    }
}
