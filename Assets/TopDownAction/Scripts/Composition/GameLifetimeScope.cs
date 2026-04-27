using UnityEngine;
using VContainer;
using VContainer.Unity;
using TopdownAction.Services;
using TopdownAction.Presentation;
using TopdownAction.Domain;

namespace TopdownAction.Composition
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] PlayerView playerView;
        [SerializeField] AudioServiceBehaviour audioBehaviour;
        [SerializeField] GameSettings settings;

        protected override void Configure(IContainerBuilder builder)
        {
            // Data
            builder.RegisterInstance(settings);

            // Services
            builder.Register<IInputService, KeyboardInputService>(Lifetime.Singleton);
            builder.RegisterComponent(audioBehaviour).As<IAudioService>();

            // Views
            builder.RegisterComponent(playerView);

            // Entry points
            builder.RegisterEntryPoint<PlayerController>();
        }
    }
}