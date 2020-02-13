using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Rigidbody cubeDestructible;
    
    public float crx = (2);
    public float cry = (2);
    public float crz = (2);
    // Start is called before the first frame update
    void FixedUpdate()
    {

        cubeDestructible.AddTorque(crx, cry, crz);
    }

    // Update is called once per frame
    
}