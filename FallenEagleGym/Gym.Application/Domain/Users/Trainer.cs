using Gym.Application.Domain.Enumeration;

namespace Gym.Application.Domain.Users;

public class Trainer: User
{
    public string Specializations { get; set; }    
    public string Biography { get; set; }
    public List<string> Licenses { get; set; }

    public Trainer(string name, string surname, Gender gender, DateOnly birthDate, string phoneNumber, string email,
        string password, string specializations, string biography, List<string> licenses)
        : base(name, surname, gender, birthDate, phoneNumber, email, password, Role.Trainer)
    {
        Specializations = specializations;
        Biography = biography;
        Licenses = licenses;
    }
    
    public Trainer(long Id, string name, string surname, Gender gender, DateOnly birthDate, string phoneNumber, string email,
        string password, string specializations, string biography, List<string> licenses)
        : base(Id, name, surname, gender, birthDate, phoneNumber, email, password, Role.Trainer)
    {
        Specializations = specializations;
        Biography = biography;
        Licenses = licenses;
    }

    public Trainer() : base()
    {
        Specializations = string.Empty;
        Biography = string.Empty;
        Licenses = [];
    }
}