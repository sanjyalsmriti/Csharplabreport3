using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connectionString = "Server=localhost;Database=tourismdb;User ID=root;Password=;";

    static void Main(string[] args)
    {
        CreateDatabaseAndTable();

        // CRUD Operations
        InsertRecord("PK Nepal Trek", "A trek through the beautiful Himalayas", 10);
        InsertRecord("Mountain Getaway", "Mountain", 5);
        ReadRecords();
        UpdateRecord(1, "Himalayan Adventure", "An adventurous trek in the Himalayas", 12);
        ReadRecords();
        DeleteRecord(2);
        ReadRecords();
    }

    static void CreateDatabaseAndTable()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // Create a database if it doesn't exist
            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS TourismDB;";
            using (var command = new MySqlCommand(createDatabaseQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Use the database
            string useDatabaseQuery = "USE TourismDB;";
            using (var command = new MySqlCommand(useDatabaseQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Create a table
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS `Tour Destination` (
                                        Id INT AUTO_INCREMENT PRIMARY KEY,
                                        Title VARCHAR(255) NOT NULL,
                                        Description TEXT NOT NULL,
                                        Duration INT NOT NULL,
                                        CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP);";

            using (var command = new MySqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Table created successfully.");
            }
        }
    }

    static void InsertRecord(string title, string description, int duration)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO `Tour Destination` (Title, Description, Duration) VALUES (@Title, @Description, @Duration);";
            using (var command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Duration", duration);
                command.ExecuteNonQuery();
                Console.WriteLine($"Inserted: {title}.");
            }
        }
    }

    static void ReadRecords()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM `Tour Destination`;";
            using (var command = new MySqlCommand(selectQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine("\nTour Destinations:");
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Title: {reader["Title"]}, Description: {reader["Description"]}, Duration: {reader["Duration"]} days, CreatedDate: {reader["CreatedDate"]}");
                }
            }
        }
    }

    static void UpdateRecord(int id, string title, string description, int duration)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE `Tour Destination` SET Title = @Title, Description = @Description, Duration = @Duration WHERE Id = @Id;";
            using (var command = new MySqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Duration", duration);
                command.ExecuteNonQuery();
                Console.WriteLine($"Updated record with Id {id}.");
            }
        }
    }

    static void DeleteRecord(int id)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM `Tour Destination` WHERE Id = @Id;";
            using (var command = new MySqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                Console.WriteLine($"Deleted record with Id {id}.");
            }
        }
    }
}
