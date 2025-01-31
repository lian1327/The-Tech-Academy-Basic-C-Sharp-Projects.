using System;
using Npgsql;

class Program
{
    static void Main(string[] args)
    {
        // Connection string to connect to PostgreSQL
        string connectionString = "Host=localhost;Username=user;Password=mypass;Database=SampleDB";

        // Create a connection to the PostgreSQL database
        using (var conn = new NpgsqlConnection(connectionString))
        {
            try
            {
                // Open the connection
                conn.Open();

                // Create a SQL command
                using (var cmd = new NpgsqlCommand("SELECT * FROM mytable", conn))
                {
                    // Execute the command and read the data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Process each row
                            Console.WriteLine(reader.GetString(0)); // Example: Read and display the first column
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
    }
}
