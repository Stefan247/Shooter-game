using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class GameOverMenuScript : MonoBehaviour
    {
        private void ExitToMenu()
        {
            SceneManager.LoadScene("MainMenu"); // Menu Scene
        }
    
        private void PlayAgain()
        {
            SceneManager.LoadScene("TheGame"); // StartGame Scene
        }
    }
}
