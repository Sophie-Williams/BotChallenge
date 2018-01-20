using Autofac;
using BotChallenge.DAL;

namespace BotChallenge.BLL
{
    static class DependencyResolver
    {
        private static IContainer container;

        private static void BuildContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new DALModule());
            container = builder.Build();
        }

        public static IContainer Container
        {
            get
            {
                if (container == null)
                {
                    BuildContainer();
                }
                return container;
            }
        }
    }
}
