using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TImeCalculator : MonoBehaviour
{
    public Text minutesDisplay;
    public Text secondsDisplay;
    public Text seconds100Display;
    
    public Timer timerScript;


    // Update is called once per frame
    void Update()
    {
        minutesDisplay.text = timerScript.timerMinutes.text;
    }
}
