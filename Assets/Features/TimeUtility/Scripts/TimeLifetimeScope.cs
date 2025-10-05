using VContainer;
using VContainer.Unity;

namespace MyGame.Features.TimeUtility
{
    public class TimeLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<TimeClient>(Lifetime.Singleton);  // “Whenever someone asks for a TimeClient, create one, keep a single shared instance (Singleton), and inject it wherever needed.”
            builder.Register<ITimeService, TimeService>(Lifetime.Singleton);  //“Whenever someone requests an ITimeService interface, give them a TimeService instance. Keep it as a Singleton.”
            builder.RegisterEntryPoint<TimeInitializer>();
            
            
#if UNITY_EDITOR
            // Only register UI in editor/test scenes
            if (FindObjectOfType<TimeUIScreen>() != null)
                builder.RegisterComponentInHierarchy<TimeUIScreen>();
#endif
        }
    }
}