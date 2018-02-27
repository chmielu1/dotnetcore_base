using System;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
	string connStr = "server=localhost;user=ehour;database=ehour;port=3306;password=qwerty";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            string sql = "SELECT * FROM USER_ROLE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
	    Console.WriteLine("ano " + cmd.ExecuteScalar());
            Console.WriteLine(string.Join("\n", cmd.ExecuteScalar()));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
	var command = new MySqlCommand("SELECT * FROM USER_ROLE;", conn);

        using (MySqlDataReader reader =  command.ExecuteReader())
        {
        while (reader.Read())
        {
            Console.WriteLine(
                //$"{reader["ROLE"]}: {reader["NAME"]} {reader["NAME"]}");
                $"{reader["ROLE"]}: {reader["NAME"]}");
        }
	}

        conn.Close();
        Console.WriteLine("Done.");
		
	}
    }
}
