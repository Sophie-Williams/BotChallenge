using BotChallenge.Shared;

namespace BotChallenge.DAL.Prototypes
{
    public interface IUserRepository : IRepository<User>
    {
        User Login(string login, string password);
    }
}
