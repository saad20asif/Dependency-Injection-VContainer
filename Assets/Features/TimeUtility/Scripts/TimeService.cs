using System;
using System.Threading.Tasks;
using UnityEngine;

namespace MyGame.Features.TimeUtility
{
    public class TimeService : ITimeService
    {
        private readonly TimeClient _client;
        private DateTime _utcNow;

        public DateTime UtcNow => _utcNow;

        public TimeService(TimeClient client)
        {
            _client = client;
            _utcNow = DateTime.UtcNow; // fallback default
        }

        public async Task InitializeAsync()
        {
            Debug.Log("[TimeService] Initializing...");

            var serverTime = await _client.FetchServerTimeAsync();
            _utcNow = serverTime ?? DateTime.UtcNow;

            Debug.Log($"[TimeService] Final UTC time: {_utcNow:O}");
        }
    }
}