//using System;
//using System.Data;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";
//        string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) VALUES (@Title, @Description, @Duration, @CreatedDate)";

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            connection.Open();

//            using (SqlCommand command = new SqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@Title", "Beautiful Beach");
//                command.Parameters.AddWithValue("@Description", "A wonderful place to visit.");
//                command.Parameters.AddWithValue("@Duration", 5);
//                command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

//                command.ExecuteNonQuery();
//            }
//        }

//        Console.WriteLine("Record inserted successfully.");
//    }
//}
