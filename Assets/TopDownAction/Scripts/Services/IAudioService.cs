// Services/IAudioService.cs
namespace TopdownAction.Services
{
    public interface IAudioService
    {
        void Play(string clipId);
        void Stop(string clipId);
    }
}