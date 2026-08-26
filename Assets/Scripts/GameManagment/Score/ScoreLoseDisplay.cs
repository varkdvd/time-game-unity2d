using System;
using TMPro;
using UnityEngine;

namespace GameManagment.Score
{
    [RequireComponent(typeof(TMP_Text))]
    public class ScoreLoseDisplay : MonoBehaviour
    {
        [SerializeField] private ScoreHolder holder; 
        private TMP_Text _display;

        private void Awake() => _display = GetComponent<TMP_Text>();

        private void OnEnable()
        {
            _display.text = holder.Score.ToString();
        }
    }
}
