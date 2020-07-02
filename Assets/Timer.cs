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
    void Start()
    {
        textBox.text = timeStart.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
               
            timeStart += Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString("0.00");
       
    }
}
