using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    
    public GameObject canvasObject;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            canvasObject.SetActive(false);            

        }
        if (Input.GetKeyDown("p"))
        {

            canvasObject.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }
        if (Input.GetKey("q"))
        {

            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }
        if (Input.GetKey("d"))
        {

            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }
        if (Input.GetKey("z"))
        {

            canvasObject.SetActive(false);
            Time.timeScale = 1f;

        }


    }

}
