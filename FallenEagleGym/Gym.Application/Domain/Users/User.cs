using Gym.Application.Domain.Enumeration;

namespace Gym.Application.Domain.Users;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
    public List<Rating> Ratings { get; set; }

    public User(long Id, string Name, string Surname, Gender Gender, DateOnly BirthDate, string PhoneNumber,
        string Email, string Password, Role Role)
    {
        this.Id = Id;
        this.Name = Name;
        this.Surname = Surname;
        this.Gender = Gender;
        this.BirthDate = BirthDate;
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
        this.Password = Password;
        this.Role = Role;
        this.Ratings = [];
    }
    
    public User(string Name, string Surname, Gender Gender, DateOnly BirthDate, string PhoneNumber,
        string Email, string Password, Role Role)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Gender = Gender;
        this.BirthDate = BirthDate;
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
        this.Password = Password;
        this.Role = Role;
        this.Ratings = [];
    }

    public User()
    {
        this.Id = -1;
        this.Name = string.Empty;
        this.Surname = string.Empty;
        this.Gender = Gender.Male;
        this.BirthDate = DateOnly.MinValue;
        this.PhoneNumber = string.Empty;
        this.Email = string.Empty;
        this.Password = string.Empty;
        this.Role = Role.User;
        this.Ratings = [];
    }  
    
    public void SetRatings (List<Rating> Ratings) 
    {
        this.Ratings = Ratings;
    }
}