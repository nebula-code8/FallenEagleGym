namespace Gym.Application.Domain;

public class Rating
{
    public long RatingId { get; private set; } 
    public long RatedId { get; private set; }
    public double Grade { get; private set; }
    public string? Comment { get; private set; }
    public Rating(long ratingId, long ratedId, double grade, string? comment)
    {
        RatingId = ratingId;
        RatedId = ratedId;
        Grade = grade;
        Comment = comment;
    }
}