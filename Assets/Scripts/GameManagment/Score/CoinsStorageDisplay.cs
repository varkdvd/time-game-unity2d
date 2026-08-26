using TMPro;
using UnityEngine;

namespace GameManagment.Score
{
    [RequireComponent(typeof(TMP_Text))]
    public class CoinsStorageDisplay : MonoBehaviour
    {
        private TMP_Text _display;

        private void Awake() => _display = GetComponent<TMP_Text>();

        private void OnEnable()
        {
            if (!PlayerPrefs.HasKey("score"))
            {
                _display.text = "0";
                return; 
            }
            _display.text = PlayerPrefs.GetInt("score").ToString();
        }
    }
}