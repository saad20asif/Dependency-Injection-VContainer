using UnityEngine;

namespace TopdownAction.Services
{
    public interface IInputService
    {
        Vector2 ReadMove();
        bool ReadFire();
    }
}