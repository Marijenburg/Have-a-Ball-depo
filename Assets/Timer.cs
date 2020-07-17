using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart ;
    public Text textBox;
    

    // Start is called before the first frame update
    public void TimerStart()
    {
        timeStart += Time.deltaTime;
      
        textBox.text = timeStart.ToString("0.00");
    }

    public void TimerStops()
    {

    }
    public void SetTimerToZero()
    {
        textBox.text = "0";
    }
    // Update is called once per frame
    void Update()
    {
        TimerStart();
       
    }
   

}

