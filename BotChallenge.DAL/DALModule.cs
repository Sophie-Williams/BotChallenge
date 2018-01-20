using Autofac;
using BotChallenge.DAL.Prototypes;
using BotChallenge.DAL.Repositories;
using BotChallenge.Shared;

namespace BotChallenge.DAL
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IRepository<User>>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            base.Load(builder);
        }
    }
}
