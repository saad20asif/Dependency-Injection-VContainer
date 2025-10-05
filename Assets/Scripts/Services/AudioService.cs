using UnityEngine;

namespace MyGame.Services
{
    public class AudioService
    {
        public void PlayStateSound(GameState state)
        {
            Debug.Log($"[Audio] Playing sound for state: {state}");
        }
    }
}