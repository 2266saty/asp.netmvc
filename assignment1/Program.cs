using System;
using System.Data.SqlClient;

namespace Connected
{
    public class Program
    {
        static void Main(string[] args)
        {
            string CS = "Server =.; Database = mydatabase; integrated security = true";
            SqlConnection conn = new SqlConnection(CS);

            try
            {
                QueryOne();
                QueryTwo();
                QueryThree();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception :" + ex.Message);
            }

            void QueryOne()
            {
                Console.WriteLine("Opening Connection");
                conn.Open();
                Console.WriteLine("Connection established successfully");
                Console.WriteLine();

                Console.WriteLine("Result of Query 1");
                string queryOne = "Select WinningTeam from FootballLeague Where Status = 'Win' ";
                SqlCommand ComOne = new SqlCommand(queryOne, conn);
                SqlDataReader readerOne = ComOne.ExecuteReader();

                while (readerOne.Read())
                {
                    Console.WriteLine("Winning Team =" + readerOne["WinningTeam"]);
                    Console.WriteLine("\n");
                }
                readerOne.Close();
            }

            void QueryTwo()
            {
                Console.WriteLine("Result of Query 2");
                string queryTwo = "Select * from Match_View";
                SqlCommand ComTwo = new SqlCommand(queryTwo, conn);
                SqlDataReader readerTwo = ComTwo.ExecuteReader();

                while (readerTwo.Read())
                {
                    Console.WriteLine("Team1 =" + readerTwo["TeamName1"] +
                                      "Team2 =" + readerTwo["TeamName2"]);
                }
                readerTwo.Close();
            }

            void QueryThree()
            {
                Console.WriteLine("Result of Query 3");
                string queryThree = "Select * from FootballLeague where TeamName1 ='Japan' OR TeamName2 = 'Japan'";
                SqlCommand ComThree = new SqlCommand(queryThree, conn);
                SqlDataReader readerThree = ComThree.ExecuteReader();

                while (!readerThree.Read())
                {
                    Console.WriteLine("MatchId =" + readerThree["MatchId"]
                                     + "Team1 =" + readerThree["TeamName1"]
                                     + "Team2 =" + readerThree["TeamName2"]
                                     + "Status =" + readerThree["Status"]
                                     + "Winner =" + readerThree["WinningTeam"]
                                     + "Points =" + readerThree["Points"]);
                }
                readerThree.Close();
            }

 
            Console.ReadKey();
        }

    }
}