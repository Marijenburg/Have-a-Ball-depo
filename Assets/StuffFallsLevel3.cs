using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffFallsLevel3 : MonoBehaviour
{
    public GameObject obstacle;
    private bool isTriggered = false;


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (isTriggered == false)

            Debug.Log("touch the FTHING");
        Instantiate(obstacle, new Vector3(0, 40, 600), Quaternion.identity);

        isTriggered = true;

    }




}
