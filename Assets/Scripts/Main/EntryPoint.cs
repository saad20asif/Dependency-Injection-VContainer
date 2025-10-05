using VContainer;
using MyGame.Services;
using VContainer.Unity;

namespace MyGame.Main
{
    public class EntryPoint : IStartable
    {
        private readonly HelloWorldService _helloWorldService;

        [Inject]
        public EntryPoint(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public void Start()
        {
            _helloWorldService.SayHello();
        }
    }
}