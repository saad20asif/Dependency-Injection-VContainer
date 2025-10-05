using VContainer;
using VContainer.Unity;
using MyGame.Services;

namespace MyGame.Main
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Register services
            builder.Register<AudioService>(Lifetime.Singleton);
            builder.Register<UIService>(Lifetime.Singleton);
            builder.Register<GameFlowService>(Lifetime.Singleton);

            // Register entry point
            builder.RegisterEntryPoint<EntryPoint>();
        }
    }
}