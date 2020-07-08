using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffFallsFromtheSky : MonoBehaviour
{
    public GameObject sphere1;
    private bool isTriggered = false;
    
    
        // Update is called once per frame
        void OnTriggerEnter(Collider other)
        {
            if (isTriggered == false)

            Debug.Log("touch the FTHING");
            Instantiate(sphere1, new Vector3(0,45, 600), Quaternion.identity);

            isTriggered = true;

        }
    

   

}
