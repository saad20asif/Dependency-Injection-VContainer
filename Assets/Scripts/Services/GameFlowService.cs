using UnityEngine;

namespace MyGame.Services
{
    public class GameFlowService
    {
        private readonly AudioService _audioService;
        private readonly UIService _uiService;

        private GameState _currentState;

        public GameFlowService(AudioService audioService, UIService uiService)
        {
            _audioService = audioService;
            _uiService = uiService;
            _currentState = GameState.Boot;
        }

        public void Initialize()
        {
            Debug.Log("[GameFlow] Initializing...");
            ChangeState(GameState.MainMenu);
        }

        public void ChangeState(GameState newState)
        {
            _currentState = newState;
            Debug.Log($"[GameFlow] State changed to: {_currentState}");

            // Simulate side effects
            _audioService.PlayStateSound(_currentState);
            _uiService.ShowStateScreen(_currentState);
        }
    }
}