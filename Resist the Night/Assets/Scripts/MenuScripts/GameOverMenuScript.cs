using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class GameOverMenuScript : MonoBehaviour
    {
    
        public void ExitToMenu()
        {
            SceneManager.LoadScene(0); // Menu Scene
        }
    
        public void PlayAgain()
        {
            SceneManager.LoadScene(1); // StartGame Scene
        }
    }
}
