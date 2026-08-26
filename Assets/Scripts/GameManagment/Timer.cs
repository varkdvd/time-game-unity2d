using System;
using TMPro;
using UnityEngine;

namespace GameManagment
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TMP_Text display;
        private const float TimeForOver = 1f;

        public static Action OnResetTime; 
        public static event Action OnGameOver;

        private bool _initialized = false; 
        private float _secondTime;

        private void Awake()
        {
            display.text = "Click to start game";
            _secondTime = TimeForOver; 
        }

        private void Update()
        {
            if (!_initialized) return;

            if (_secondTime < 0f)
            {
                Debug.Log("game over");
                Time.timeScale = 0f;
                
                OnGameOver?.Invoke();
                enabled = false; 
            }
            else
            {
                _secondTime -= Time.deltaTime;
                display.text = $"Timer: {_secondTime.ToString("F2")}"; 
                SwitchColorByTime();
            }
        }

        private void RestartScore()
        {
            _initialized = true;
            _secondTime = TimeForOver;
        }

        private void OnEnable() => OnResetTime += RestartScore;
        private void OnDisable() => OnResetTime -= RestartScore;

        private void SwitchColorByTime()
        {
            if (_secondTime > 0.5f)
            {
                var t = Mathf.InverseLerp(1f, 0.5f, _secondTime);
                display.color = Color.Lerp(Color.green, Color.yellow, t);
            }
            else
            {
                var t = Mathf.InverseLerp(0.5f, 0f, _secondTime);
                display.color = Color.Lerp(Color.yellow, Color.red, t);
            }
        }
    }
}
