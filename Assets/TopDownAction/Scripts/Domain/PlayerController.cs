// Domain/PlayerController.cs
using VContainer.Unity;
using TopdownAction.Services;
using TopdownAction.Presentation;

namespace TopdownAction.Domain
{
    public class PlayerController : ITickable
    {
        readonly IInputService input;
        readonly PlayerView view;

        public PlayerController(IInputService input, PlayerView view)
        {
            this.input = input;
            this.view = view;
        }

        void ITickable.Tick()
        {
            var move = input.ReadMove();
            view.Move(move);
            if (input.ReadFire()) view.Fire();
        }
    }
}