using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    public GameObject CanvasObject;
    public void PlayerReady ()
    {
        CanvasObject.SetActive(false);
    }

}
