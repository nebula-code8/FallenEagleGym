using System.Data;
using Gym.Application.Domain.Enumeration;
using Gym.Application.Domain.Users;

namespace Gym.Application.Domain.RepositoryInerfaces;

public interface IUserRepository
{

    public (long Id, Role Role)? AuthenticateUser(string email, string password);
    public long Insert(User user);
    public int Update(User user);
} 