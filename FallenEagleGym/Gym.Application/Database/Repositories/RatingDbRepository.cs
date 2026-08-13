using System.Data;
using Gym.Application.Domain;

namespace Gym.Application.Database.Repositories;

public class RatingDbRepository: BaseRepository
{
    public List<Rating> GetRatedPersonRatings (long userId)
    {
        using IDbConnection connection = CreateConnection();
        using IDbCommand command = connection.CreateCommand();
        command.CommandText = @"SELECT * FROM user_ratings "
                              + "WHERE taker_id = @userId;";
        AddParameter(command, "userId", userId);
        using IDataReader reader = command.ExecuteReader();

        List<Rating> ratings = new List<Rating>();
        while (reader.Read())
        {
            var rating = MapDbRowToRating(reader);
            ratings.Add(rating);
        }

        return ratings;
    }

    public Rating MapDbRowToRating(IDataReader reader)
    {
        Rating rating = new Rating(Convert.ToInt64(reader["giver_id"]), Convert.ToInt64(reader["taker_id"]), Convert.ToDouble(reader["grade"]), reader["comment_"].ToString());
        return rating;
    }
}