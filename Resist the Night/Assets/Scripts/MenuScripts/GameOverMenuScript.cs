using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class GameOverMenuScript : MonoBehaviour
    {
        private void ExitToMenu()
        {
            SceneManager.LoadScene(0); // Menu Scene
        }
    
        private void PlayAgain()
        {
            SceneManager.LoadScene(1); // StartGame Scene
        }
    }
}
