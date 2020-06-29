using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void tryAgain ()
    {
        Lifecounter.numberoflives = 5;
        Uicubecounter.numberOfCubes = 0;
        SceneManager.LoadScene("Level1");
    }
}
