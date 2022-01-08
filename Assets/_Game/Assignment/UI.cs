using System;
using DefaultNamespace.ScriptableEvents;
using TMPro;
using UnityEngine;
using Variables;

namespace UI
{
    public class UI : MonoBehaviour
    {
        [Header("Health:")]
        [SerializeField] private IntVariable _healthVar;
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        
        [Header("Score:")]
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private int _destroyedAsteroids = 0;

        [Header("Timer:")]
        [SerializeField] private TextMeshProUGUI _timerText;
        [SerializeField] private int _timer = 0;

        [Header("Laser:")]
        [SerializeField] private TextMeshProUGUI _laserText;
        [SerializeField] private int _lasersFired = 0;
        
        
        private void Start()
        {
            SetHealthText($"Health: {_healthVar.Value}");
        }

        public void OnHealthChanged(IntReference newValue)
        {
            SetHealthText($"Health: {newValue.GetValue()}");
        }

        private void SetHealthText(string text)
        {
            _healthText.text = text;
        }

        public void OnDestroyedAsteroid()
        {
            _destroyedAsteroids++;
            SetDestroyedAsteroidsText($"Asteroids Destoyed: {_destroyedAsteroids}");
        }
        
        private void SetDestroyedAsteroidsText(string text)
        {
            _scoreText.text = text;
        }        

        public void OnLaserFired()
        {
            _lasersFired ++;
            SetLaserText($"Lasers fired: {_lasersFired}");
        }
        
        private void SetLaserText(string text)
        {
            _laserText.text = text;
        }

        public void OnTimerEvent()
        {
            _timer++;
            SetTimerText($"Timer: {_timer}");
        }

        private void SetTimerText(string text)
        {
            _timerText.text = text;
        }
    }
}
