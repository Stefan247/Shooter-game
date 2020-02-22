using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
   public class MainMenuScript : MonoBehaviour
   {
      private void StartGame()
      {
         SceneManager.LoadScene("TheGame"); // Start Game
      }
   
      private void QuitGame()
      {
         Application.Quit(); // Exit game
      }
   }
}
