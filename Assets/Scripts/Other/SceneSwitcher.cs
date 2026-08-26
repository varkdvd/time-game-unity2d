using GameManagment.Score;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Other
{
    public class SceneSwitcher : MonoBehaviour
    {
        [Header("Additional")]
        [SerializeField] private ScoreHolder scoreHolder; 
        
        public void SwitchScene(int sceneIndex)
        {
            scoreHolder?.SaveScore();
            Time.timeScale = 1;
            SceneManager.LoadScene(sceneIndex);
        }

        public void ReloadScene()
        {
            scoreHolder?.SaveScore();
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}