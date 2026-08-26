using UnityEngine;

namespace GameManagment.GameOver
{
    public class GameOverHandler : MonoBehaviour
    {
        [SerializeField] private GameObject standardUI;
        [SerializeField] private GameObject gameOverUI;

        private void OnEnable() => Timer.OnGameOver += GameOver; 
        private void OnDisable() => Timer.OnGameOver -= GameOver;

        private void GameOver()
        {
            standardUI.SetActive(false);
            gameOverUI.SetActive(true); 
            Time.timeScale = 0;
        }
    }
}