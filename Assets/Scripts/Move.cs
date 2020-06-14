using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody obstacle;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;   
    public float rx = 0f;
    public float ry = 0f;
    public float rz = 0f;
    // Start is called before the first frame update
    void Start()
    {
        obstacle.AddForce(x, y, z, ForceMode.Impulse);
        obstacle.AddTorque(rx,  ry,  rz);
    }

    // Update is called once per frame
    void Update()
    {
        return;
    }
}
