using UnityEngine;

namespace TopdownAction.Services
{
    public class KeyboardInputService : IInputService
    {
        public Vector2 ReadMove()
        {
            return new Vector2(Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical"));
        }

        public bool ReadFire() => Input.GetButtonDown("Fire1");
    }
}