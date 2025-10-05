using UnityEngine;

namespace MyGame.Services
{
    public class UIService
    {
        public void ShowStateScreen(GameState state)
        {
            Debug.Log($"[UI] Showing UI for state: {state}");
        }
    }
}