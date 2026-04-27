using TopdownAction.Domain;
using UnityEngine;
using VContainer;
using TopdownAction.Services;

namespace TopdownAction.Presentation
{
    public class PlayerView : MonoBehaviour
    {
        float speed;
        IAudioService audio;

        [Inject]
        public void Construct(GameSettings settings, IAudioService audio)
        {
            this.speed = settings.moveSpeed;
            this.audio = audio;
        }

        public void Move(Vector2 dir) => transform.position +=
            (Vector3)dir * (speed * Time.deltaTime);

        public void Fire() => audio.Play("fire");
    }
}