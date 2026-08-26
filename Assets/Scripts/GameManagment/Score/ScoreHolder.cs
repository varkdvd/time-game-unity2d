using TMPro;
using UnityEngine;
using System;

namespace GameManagment.Score
{
    public class ScoreHolder : MonoBehaviour
    {
        [SerializeField] private TMP_Text display;
        private int _score;

        public static Action AddScore;
        public int Score => _score; 
        
        private void OnEnable() => AddScore += ChangeScore;
        private void OnDisable() => AddScore -= ChangeScore;

        private void ChangeScore()
        {
            _score++;
            display.text = _score.ToString();
        }

        public void SaveScore()
        {
            if (!PlayerPrefs.HasKey("score"))
            {
                PlayerPrefs.SetInt("score", _score);
                return; 
            }
            var secondScore = PlayerPrefs.GetInt("score"); 
            secondScore += _score;
            PlayerPrefs.SetInt("score", secondScore);
        }
    }
}