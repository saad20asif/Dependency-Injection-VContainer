using MyGame.Services;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace MyGame.UI
{
    public class ProgressUIController : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private Button increaseButton;
        [SerializeField] private Button resetButton;

        private UIProgressService _progressService;

        [Inject]
        public void Construct(UIProgressService progressService)
        {
            _progressService = progressService;
        }

        private void Awake()
        {
            increaseButton.onClick.AddListener(OnIncrease);
            resetButton.onClick.AddListener(OnReset);
        }

        private void OnIncrease()
        {
            _progressService.Increase();
            slider.value = _progressService.NormalizedProgress;
        }

        private void OnReset()
        {
            _progressService.Reset();
            slider.value = _progressService.NormalizedProgress;
        }
    }
}