// Presentation/AudioServiceBehaviour.cs
using UnityEngine;
using TopdownAction.Services;

namespace TopdownAction.Presentation
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioServiceBehaviour : MonoBehaviour, IAudioService
    {
        [SerializeField] AudioClip fireClip;
        [SerializeField] AudioClip hitClip;

        AudioSource source;

        void Awake() => source = GetComponent<AudioSource>();

        public void Play(string clipId)
        {
            var clip = clipId switch
            {
                "fire" => fireClip,
                "hit"  => hitClip,
                _ => null
            };
            if (clip != null) source.PlayOneShot(clip);
        }

        public void Stop(string clipId) => source.Stop();
    }
}