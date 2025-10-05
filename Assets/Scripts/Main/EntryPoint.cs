using VContainer;
using VContainer.Unity;
using MyGame.Services;
using UnityEngine;

namespace MyGame.Main
{
    public class EntryPoint : IStartable, ITickable
    {
        private readonly GameFlowService _gameFlow;
        private float _timer;
        private int _step = 0;

        [Inject]
        public EntryPoint(GameFlowService gameFlow)
        {
            _gameFlow = gameFlow;
        }

        public void Start()
        {
            _gameFlow.Initialize();
        }

        public void Tick()
        {
            _timer += Time.deltaTime;

            if (_step == 0 && _timer > 3f)
            {
                _gameFlow.ChangeState(GameState.Gameplay);
                _step++;
            }
        }
    }
}