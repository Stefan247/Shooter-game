using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
   public class MainMenuScript : MonoBehaviour
   {
      private void StartGame()
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Start Game
         /*
          *  SceneManager.LoadScene(1);
          */
      }
   
      private void QuitGame()
      {
         Application.Quit(); // Exit game
      }
   }
}
