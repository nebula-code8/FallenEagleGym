using Gym.Application.Domain.Enumeration;

namespace Gym.Application.Domain.Users;

public class User
{
    public long Id { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public Gender Gender { get; private set; } 
    public DateOnly BirthDate { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }
    public List<Rating> Ratings { get; private  set; }

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