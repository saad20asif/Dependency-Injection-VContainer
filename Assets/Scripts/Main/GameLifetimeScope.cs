using VContainer;
using VContainer.Unity;
using MyGame.Services;

namespace MyGame.Main
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Register our HelloWorldService
            builder.Register<HelloWorldService>(Lifetime.Singleton);

            // Register EntryPoint so VContainer can inject into it
            builder.RegisterEntryPoint<EntryPoint>();
        }
    }
}