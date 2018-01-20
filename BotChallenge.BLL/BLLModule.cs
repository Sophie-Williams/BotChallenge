using Autofac;
using BotChallenge.BLL.Prototypes;
using BotChallenge.BLL.Services;
using BotChallenge.Shared;

namespace BotChallenge.BLL
{
    public class BLLModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserService>().As<IDAService<User>>();

            base.Load(builder);
        }
    }
}
