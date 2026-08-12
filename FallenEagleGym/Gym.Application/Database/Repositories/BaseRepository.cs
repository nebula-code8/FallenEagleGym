using System.Data;

namespace Gym.Application.Database.Repositories;

public class BaseRepository
{
    protected static IDbConnection CreateConnection()
    {
        return PostgresConnection.CreateConnection();
    }

    protected static void AddParameter(IDbCommand command, string name, object? value)
    {
        var param = command.CreateParameter();
        param.ParameterName = name;
        param.Value = value ?? DBNull.Value;
        command.Parameters.Add(param);
    }
}