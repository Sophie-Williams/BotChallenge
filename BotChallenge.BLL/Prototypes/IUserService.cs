using BotChallenge.Shared;

namespace BotChallenge.BLL.Prototypes
{
    public interface IUserService : IDAService<User>
    {
        User Login(string login, string name);
    }
}
