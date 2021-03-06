﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour { 

    bool gameHasEnded = false;

    public float restartDelay = 30f;

    public GameObject completeLevelUI;
    public GameObject canvasYourTime;



    public void CompleteLevel ()
                   {
        completeLevelUI.SetActive(true);      
                     }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Lifecounter.numberoflives -= 1;
            Invoke("Restart", restartDelay);
            //Restart Game
        }
       
    }
    

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
