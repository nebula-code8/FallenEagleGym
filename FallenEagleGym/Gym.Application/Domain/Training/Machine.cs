namespace Gym.Application.Domain.Training;

public class Machine: Accessory
{
    public Machine(string name, string description)
        : base(name, description) { }
    
    public Machine(long id, string name, string description)
        : base(id, name, description) { }
}