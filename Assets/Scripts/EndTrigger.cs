﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Timer time;
    public Timer yourTime;
    public GameObject yourTimeCanvas;
    

            void OnTriggerEnter(Collider other)

             {

               if (other.CompareTag("Player"))
                   time.TimerStop();
                    yourTime.TimerStop();
                 yourTimeCanvas.SetActive(true);
                 gameManager.CompleteLevel();
    
             }
}
