// See https://aka.ms/new-console-template for more information

using System.Data;

try
{
    IDbConnection connection = PostgresConnection.CreateConnection();
    IDbCommand command = connection.CreateCommand();
    command.CommandText = @"SELECT * FROM users";
    command.ExecuteScalar();
    Console.WriteLine("Sve je proslo kako valja");
}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.Message);
}
