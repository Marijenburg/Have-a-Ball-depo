using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public Timer time;
    public Timer yourTime;
    public GameObject canvasObject;
    public GameObject canvasYourTime;
    // Start is called before the first frame update
    void Start()
    {      
        Time.timeScale = 0f;
        Cursor.visible = false;
       
    }
    void GOGOGO()
    {
        time.TimerStart();
        yourTime.TimerStart();
        canvasObject.SetActive(false);
        canvasYourTime.SetActive(false);
        Time.timeScale = 1f;
    }
    void Pause()
    {
        time.TimerStop();
        yourTime.TimerStop();
        canvasObject.SetActive(false);
        canvasYourTime.SetActive(true);
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
        if (Input.GetKeyDown("p"))
        {
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GOGOGO();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GOGOGO();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GOGOGO();
        }
        if (Input.GetKey("q"))
        {
            GOGOGO();
        }
        if (Input.GetKey("d"))
        {
            GOGOGO();
        }
        if (Input.GetKey("z"))
        {
            GOGOGO();
        }
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            GOGOGO();
        }

    }

}
