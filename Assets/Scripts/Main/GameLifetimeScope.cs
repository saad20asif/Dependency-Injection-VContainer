using VContainer;
using VContainer.Unity;
using MyGame.Services;
using MyGame.UI;

namespace MyGame.Main
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Register our service (you can change partition count here)
            builder.Register<UIProgressService>(Lifetime.Singleton)
                .WithParameter("partitions", 5);

            // Automatically inject into scene MonoBehaviours
            builder.RegisterComponentInHierarchy<ProgressUIController>();
        }
    }
}