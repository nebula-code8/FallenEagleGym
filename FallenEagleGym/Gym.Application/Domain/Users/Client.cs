using Gym.Application.Domain.Enumeration;
using Gym.Application.Domain.Training;

namespace Gym.Application.Domain.Users;

public class Client: User
{
   public double Height { get; private set; }
   public double Weight { get; private set; }  
   public string Goal { get; private set; }
   public TrainingLocation TrainingLocation { get; private set; }
   public string HealthProblems { get; private set; }
   public List<Accessory> Accessories { get; private set; }

   public Client(string name, string surname, Gender gender, DateOnly birthDate, string phoneNumber,
       string email, string password, double height, double weight, string goal, TrainingLocation trainingLocation,
       string healthProblems, List<Accessory> accessories)
       : base(name, surname, gender, birthDate, phoneNumber, email, password, Role.Trainer)
   {
       Height = height;
       Weight = weight;
       Goal = goal;
       TrainingLocation = trainingLocation;
       HealthProblems = healthProblems;
   }
   
   public Client(long id, string name, string surname, Gender gender, DateOnly birthDate, string phoneNumber,
       string email, string password, double height, double weight, string goal, TrainingLocation trainingLocation,
       string healthProblems, List<Accessory> accessories)
       : base(id, name, surname, gender, birthDate, phoneNumber, email, password, Role.Trainer)
   {
       Height = height;
       Weight = weight;
       Goal = goal;
       TrainingLocation = trainingLocation;
       HealthProblems = healthProblems;
   }
}