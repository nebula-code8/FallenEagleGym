namespace Gym.Application.Domain;

public class Rating
{
    public long UserId { get; set; } 
    public double Grade { get; set; }
    public string? Comment { get; set; }
    public Rating(long userId, double grade, string? comment)
    {
        UserId = userId;
        Grade = grade;
    }
}