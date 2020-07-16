using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    public GameObject CanvasObject;
    public Timer timer;

    public void Start()
    {
        timer.SetTimerToZero();
        Debug.Log("TIME TO 00.00");
    }
    public void PlayerReady ()
    {
        CanvasObject.SetActive(false);
        timer.SetTimerToZero();
        Debug.Log("TIME TO 00.00 AGAIN");
    }

}
