using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lifecounter : MonoBehaviour
{
    public float tryAgainDelay = 10f;

    public RawImage life1;
    public RawImage life2;
    public RawImage life3;   
    public RawImage life4;
    public RawImage life5;
    public RawImage life6;
    public RawImage life7;
    public RawImage life8;
    public RawImage life9;
    public RawImage life10;

    public static double numberoflives = 5;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {

        life1.enabled = false;
        life2.enabled = false;
        life3.enabled = false;
        life4.enabled = false;
        life5.enabled = false;
        life6.enabled = false;
        life7.enabled = false;
        life8.enabled = false;
        life9.enabled = false;
        life10.enabled = false;


        //10
        if (numberoflives == 10)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = true;
            life7.enabled = true;
            life8.enabled = true;
            life9.enabled = true;
            life10.enabled = true;
        }
        //9
        if (numberoflives == 9)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = true;
            life7.enabled = true;
            life8.enabled = true;
            life9.enabled = true;
            life10.enabled = false;
        }
        //8
        if (numberoflives == 8)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = true;
            life7.enabled = true;
            life8.enabled = true;
            life9.enabled = false;
            life10.enabled = false;
        }
        //7
        if (numberoflives == 7)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = true;
            life7.enabled = true;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //6
        if (numberoflives == 6)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = true;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //5
        if (numberoflives == 5)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = true;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //4
        if (numberoflives == 4)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = true;
            life5.enabled = false;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //3
        if (numberoflives == 3)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
            life4.enabled = false;
            life5.enabled = false;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //2
        if (numberoflives <= 2)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = false;
            life4.enabled = false;
            life5.enabled = false;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }
        //1
        if (numberoflives == 1)
        {
            life1.enabled = true;
            life2.enabled = false;
            life3.enabled = false;
            life4.enabled = false;
            life5.enabled = false;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
        }

        //0
        if (numberoflives == 0)
        {
            life1.enabled = false;
            life2.enabled = false;
            life3.enabled = false;
            life4.enabled = false;
            life5.enabled = false;
            life6.enabled = false;
            life7.enabled = false;
            life8.enabled = false;
            life9.enabled = false;
            life10.enabled = false;
            Invoke("youLost", 1);
            
        }     
        
        Debug.Log("lives" + numberoflives);
    }
    void youLost()
    {
        SceneManager.LoadScene("TryAgain");
    }
}
