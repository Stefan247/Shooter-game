using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class PauseMenu : MonoBehaviour
    {

        public static bool IsPaused;
        public GameObject pauseMenu;
        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Escape)) return;
            if (IsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        public void ResumeGame()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            IsPaused = false;
        }

        public void GoToMenu()
        {
            Time.timeScale = 1f;
            IsPaused = false;
            pauseMenu.SetActive(false);
            SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
        
        public void PauseGame()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            IsPaused = true;
        }
    }
}
