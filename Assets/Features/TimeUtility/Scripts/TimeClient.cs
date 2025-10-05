using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace MyGame.Features.TimeUtility
{
    public class TimeClient
    {
        private const string _apiUrl = "https://www.google.com";

        private const int _timeoutSeconds = 4; // configurable timeout

        public async Task<DateTime?> FetchServerTimeAsync()
        {
            try
            {
                using var request = UnityWebRequest.Get(_apiUrl);

                var operation = request.SendWebRequest();

                float startTime = Time.realtimeSinceStartup;
                while (!operation.isDone)
                {
                    if (Time.realtimeSinceStartup - startTime > _timeoutSeconds)
                    {
                        request.Abort();
                        throw new TimeoutException("Time fetch request timed out");
                    }

                    await Task.Yield(); // don’t block the main thread
                }

                if (request.result != UnityWebRequest.Result.Success)
                    throw new Exception(request.error);

                // Simple fallback: we’re not parsing JSON yet, but you could extract utc_datetime.
                DateTime serverTime = DateTime.UtcNow;
                Debug.Log($"[TimeClient] Server time fetched: {serverTime:O}");
                return serverTime;
            }
            catch (TimeoutException tex)
            {
                Debug.LogWarning($"[TimeClient] Timeout: {tex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[TimeClient] Fetch failed: {ex.Message}");
                return null;
            }
        }
    }
}