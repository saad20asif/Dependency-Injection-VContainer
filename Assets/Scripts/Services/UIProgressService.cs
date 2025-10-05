using UnityEngine;

namespace MyGame.Services
{
    public class UIProgressService
    {
        private readonly int _partitions;
        private float _progress;
        public float NormalizedProgress => _progress;

        public UIProgressService(int partitions)
        {
            _partitions = Mathf.Max(1, partitions);
            _progress = 0f;
        }

        public void Increase()
        {
            _progress += 1f / _partitions;
            _progress = Mathf.Clamp01(_progress);
            Debug.Log($"[ProgressService] Increased -> {_progress}");
        }

        public void Reset()
        {
            _progress = 0f;
            Debug.Log("[ProgressService] Reset");
        }
    }
}