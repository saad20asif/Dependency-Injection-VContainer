using Cysharp.Threading.Tasks;
using System.Threading;
using VContainer;
using VContainer.Unity;

namespace MyGame.Features.TimeUtility
{
    public class TimeInitializer : IAsyncStartable
    {
        private readonly ITimeService _timeService;

        [Inject]
        public TimeInitializer(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            await _timeService.InitializeAsync();
        }
    }
}