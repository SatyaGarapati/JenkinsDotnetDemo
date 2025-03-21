// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.Data.SqlClient;

public class Program
{
    private static void Main(string[] args)
    {
        string connectionString = "Server=devsql.devzilla.local;Database=fzgboerse_live;User Id=sa;Password=Dotzilla2204;Encrypt=False;TrustServerCertificate=True;";

        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}