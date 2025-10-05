using System;
using System.Threading.Tasks;

namespace MyGame.Features.TimeUtility
{
    public interface ITimeService
    {
        DateTime UtcNow { get; }
        Task InitializeAsync();
    }
}