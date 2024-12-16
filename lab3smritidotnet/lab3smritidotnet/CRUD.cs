//using System;
//using System.Data.SqlClient;
//using MySql.Data.MySqlClient;

//class Program
//{
//    static string connectionString = "Server=localhost;Database=crud;User ID=root;Password=;";

//    static void Main(string[] args)
//    {
//        CreateDatabaseAndTable();

//        // CRUD Operations
//        InsertRecord("Smriti", 25);
//        InsertRecord("Ishu", 30);
//        ReadRecords();
//        UpdateRecord(1, "Dinsmi", 26);
//        ReadRecords();
//        DeleteRecord(2);
//        ReadRecords();
//    }

//    static void CreateDatabaseAndTable()
//    {
//        using (var connection = new MySqlConnection(connectionString))
//        {
//            connection.Open();

//            // Create a database if it doesn't exist
//            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS crud;";
//            using (var command = new MySqlCommand(createDatabaseQuery, connection))
//            {
//                command.ExecuteNonQuery();
//            }

//            // Use the database
//            string useDatabaseQuery = "USE crud;";
//            using (var command = new MySqlCommand(useDatabaseQuery, connection))
//            {
//                command.ExecuteNonQuery();
//            }

//            // Create a table
//            string createTableQuery = @"CREATE TABLE IF NOT EXISTS People (
//                                        Id INT AUTO_INCREMENT PRIMARY KEY,
//                                        Name VARCHAR(255) NOT NULL,
//                                        Age INT NOT NULL);"
//            ;

//            using (var command = new MySqlCommand(createTableQuery, connection))
//            {
//                command.ExecuteNonQuery();
//                Console.WriteLine("Table created successfully.");
//            }
//        }
//    }

//    static void InsertRecord(string name, int age)
//    {
//        using (var connection = new MySqlConnection(connectionString))
//        {
//            connection.Open();

//            string insertQuery = "INSERT INTO People (Name, Age) VALUES (@Name, @Age);";
//            using (var command = new MySqlCommand(insertQuery, connection))
//            {
//                command.Parameters.AddWithValue("@Name", name);
//                command.Parameters.AddWithValue("@Age", age);
//                command.ExecuteNonQuery();
//                Console.WriteLine($"Inserted {name}, {age}.");
//            }
//        }
//    }

//    static void ReadRecords()
//    {
//        using (var connection = new MySqlConnection(connectionString))
//        {
//            connection.Open();

//            string selectQuery = "SELECT * FROM People;";
//            using (var command = new MySqlCommand(selectQuery, connection))
//            using (var reader = command.ExecuteReader())
//            {
//                Console.WriteLine("\nRecords:");
//                while (reader.Read())
//                {
//                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
//                }
//            }
//        }
//    }

//    static void UpdateRecord(int id, string name, int age)
//    {
//        using (var connection = new MySqlConnection(connectionString))
//        {
//            connection.Open();

//            string updateQuery = "UPDATE People SET Name = @Name, Age = @Age WHERE Id = @Id;";
//            using (var command = new MySqlCommand(updateQuery, connection))
//            {
//                command.Parameters.AddWithValue("@Id", id);
//                command.Parameters.AddWithValue("@Name", name);
//                command.Parameters.AddWithValue("@Age", age);
//                command.ExecuteNonQuery();
//                Console.WriteLine($"Updated record with Id {id}.");
//            }
//        }
//    }

//    static void DeleteRecord(int id)
//    {
//        using (var connection = new MySqlConnection(connectionString))
//        {
//            connection.Open();

//            string deleteQuery = "DELETE FROM People WHERE Id = @Id;";
//            using (var command = new MySqlCommand(deleteQuery, connection))
//            {
//                command.Parameters.AddWithValue("@Id", id);
//                command.ExecuteNonQuery();
//                Console.WriteLine($"Deleted record with Id {id}.");
//            }
//        }
//    }
//}
