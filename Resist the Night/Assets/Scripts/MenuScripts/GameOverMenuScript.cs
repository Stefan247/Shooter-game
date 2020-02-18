using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuScript : MonoBehaviour
{
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
