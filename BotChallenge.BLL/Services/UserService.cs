using BotChallenge.DAL.Prototypes;
using Autofac;
using BotChallenge.Shared;

namespace BotChallenge.BLL.Services
{
    class UserService : IUserRepository
    {
        private IUserRepository userRepository;

        UserService()
        {
            userRepository = DependencyResolver.Container.Resolve<IUserRepository>();
        }

        public void Add(User item)
        {
            userRepository.Add(item);
        }

        public void Delete(string id)
        {
            userRepository.Delete(id);
        }

        public User Get(string id)
        {
            return userRepository.Get(id);
        }

        public User Login(string login, string password)
        {
            return userRepository.Login(login, password);
        }

        public void Update(User item)
        {
            userRepository.Update(item);
        }
    }
}
