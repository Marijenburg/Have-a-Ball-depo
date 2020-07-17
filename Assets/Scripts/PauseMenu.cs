using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
   

   

    void Update()
    {
        // TO PAUSE
        if (Input.GetKey(KeyCode.Joystick1Button7))
        {

            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Pause();                             
                GetComponent<StartLevel>().enabled = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Pause();
               
                GetComponent<StartLevel>().enabled = false;
               
            }
        }
        if (Input.GetKeyDown("p"))
        {

            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Pause();
                
                GetComponent<StartLevel>().enabled = false;
            }
        }
       
        // TO RESUME
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            if (GameIsPaused)
            {          
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();
                GetComponent<StartLevel>().enabled = false;
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();             
                GetComponent<StartLevel>().enabled = false;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();              
                GetComponent<StartLevel>().enabled = false;
            }

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))                    
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();
                GetComponent<StartLevel>().enabled = false;
            }

        }
        if (Input.GetKey("d"))
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();
                GetComponent<StartLevel>().enabled = false;
            }

        }
        if (Input.GetKey("q"))
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();
                GetComponent<StartLevel>().enabled = false;
            }

        }
        if (Input.GetKey("z"))
        {
            if (GameIsPaused)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                Resume();
                GetComponent<StartLevel>().enabled = false;
            }

        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GetComponent<StartLevel>().enabled = false;
        
    }
    void Pause ()
    {    
      
      
           
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
        GetComponent<StartLevel>().enabled = false;
      
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
    public void tryAgain2()
    {
        Lifecounter.numberoflives = 5;
        Uicubecounter.numberOfCubes = 0;
        SceneManager.LoadScene("Level1");
    }

}
