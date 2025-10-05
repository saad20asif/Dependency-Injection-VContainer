using UnityEngine;
using UnityEngine.UI;
using TMPro;
using VContainer;

namespace MyGame.Features.TimeUtility
{
    public class TimeUIScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timeText;
        [SerializeField] private Button refreshButton;

        private ITimeService _timeService;

        [Inject]
        public void Construct(ITimeService timeService)
        {
            _timeService = timeService;
        }

        private void Start()
        {
            UpdateTimeLabel();
            refreshButton.onClick.AddListener(OnRefreshClicked);
        }

        private async void OnRefreshClicked()
        {
            timeText.text = "Fetching...";
            await _timeService.InitializeAsync();
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            timeText.text = $"UTC Time:\n{_timeService.UtcNow:HH:mm:ss}";
        }
    }
}