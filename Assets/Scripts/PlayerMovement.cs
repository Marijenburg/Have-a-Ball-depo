using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{

    public LayerMask groundLayers;
    public Rigidbody rb;
    public float forwardForce = 40f;
    public float edgeForwardForce = 10f;
    public float edgeForwardForceInair = 100f;
    public float sidewaysForce = 25f;
    public float forwardInair = 300f;
    public float sidewaysInair = 300f;
    public float jumpForce = 12f;
    public SphereCollider col;
    public float sideForceController = 2f;
    public float sideAirForceController = 1f;
    public AudioSource jumpSound;
    public AudioSource rollingSound;
    public AudioSource landingSound;
    public AudioSource powerUp;
    
   

    void FixedUpdate()
    {
        
        //Die and Reset if Falls from surface
        if (rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        MovewithController();
        JumpWithController();
        Jump();
        PushForward();   
        RollingSound();


        // Mouse cursor invisible
        Cursor.visible = false;

    }

    // Line for the LANDING SOUND
    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "Ground")
        {
            {

                landingSound.Play();
                Debug.Log("sound landing PLAY");
            }
        }
        if (collision.gameObject.tag == "cubedestructible")
        {
            {

                powerUp.Play();
                Debug.Log("sound landing PLAY");
            }
        }
    }
            

   
    public void RollingSound()
    {
        if (IsGrounded())
        {
            if (!rollingSound.isPlaying)
            {
                rollingSound.Play();
            }          
        }
        else
        {
            rollingSound.Stop();
        }
       if (rollingSound.isPlaying)
        {
            if (Time.timeScale==0)
            {
                rollingSound.Pause();
            }
        }
    }
   
    private void JumpWithController()
    {
        //jump with controller
        if (IsGrounded() && Input.GetKey(KeyCode.Joystick1Button0))

        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpSound.Play();
        }
    }
    private void MovewithController()
    {
  // __________________________________________________To move sideways______________________________________________
        if (IsGrounded())
        {
           
            rb.AddForce(sidewaysForce * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,  0f, ForceMode.VelocityChange);
            
        }
        else
        {
            
            rb.AddForce(sidewaysInair * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
            
        }

  // ___________________________________________________THE EDGE_______________________________________________________
        if (IsGrounded())
        {
           
            rb.AddForce(0f, 0f, edgeForwardForce * Input.GetAxis("Vertical") * Time.deltaTime, ForceMode.VelocityChange) ;
        }
        else
        {
            
            rb.AddForce(0f, 0f, edgeForwardForceInair * Input.GetAxis("Vertical") * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
   private void PushForward()
    {
        if (IsGrounded())
        {
            rb.AddForce(0, 0, forwardForce, ForceMode.Force);
          
        }
        else
        {
            rb.AddForce(0, 0, forwardInair, ForceMode.Force);
        }
    }
    public bool IsGrounded()
   
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
                col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);

    }   
    private void Jump()
    {
        if (IsGrounded() && Input.GetKeyUp(KeyCode.Space))

        {
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jumpSound.Play();
            }

        }
       


    }
    /*private void MovingAround()
    {
           
//-----------------------------------------------------STRAIGHT--------------------------------------------------
    // STRAIGHT ZQSD
    if (IsGrounded())
    {

        if (Input.GetKey("z"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime,  ForceMode.Impulse) ;

        }
    }
    else
   if (Input.GetKey("z"))
    {
        rb.AddForce (0, 0, forwardInair * Time.deltaTime,   ForceMode.Acceleration);
    }

    // STRAIGHT ARROWS
    if (IsGrounded())
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime,   ForceMode.Impulse);

        }
    }
    else
   if (Input.GetKey(KeyCode.UpArrow))
    {
        rb.AddForce(0, 0, forwardInair * Time.deltaTime,   ForceMode.Acceleration);
    }

//-----------------------------------------------------BACKWARDS--------------------------------------------------
    // BACKWARDS ZQSD
    if (IsGrounded())
    {

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime,  ForceMode.Impulse);

        }
    }
    else
   if (Input.GetKey("s"))
    {
        rb.AddForce(0, 0, -forwardInair * Time.deltaTime,   ForceMode.Acceleration);
    }

    // BACKWARDS ARROWS
    if (IsGrounded())
    {

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime,   ForceMode.Impulse);

        }
    }
    else
   if (Input.GetKey(KeyCode.DownArrow))
    {
        rb.AddForce(0, 0, -forwardInair * Time.deltaTime,  ForceMode.Acceleration);
    }
   
        //-------------------------------------------------------RIGHT--------------------------------------------------------
        //RIGHT arrows

        if (IsGrounded())          
          {             
              if (Input.GetKey(KeyCode.RightArrow))
                {
              rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.Force);

                }
          }
          else
           if (Input.GetKey(KeyCode.RightArrow))
        {
              rb.AddForce(sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
          }
        // go right qzd
        if (IsGrounded())
        {

            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Force);

            }
        }
        else
          if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }

 //---------------------------------------------------------LEFT------------------------------------------------------------
        //go left arrows
        if (IsGrounded())
          { 
              if (Input.GetKey(KeyCode.LeftArrow))
            {
              rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Force);
                  }
          }
          else
          {
              if (Input.GetKey("q"))
            {
                  rb.AddForce(-sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
              }
          }
        //go left qzd
        if (IsGrounded())
        {
            if (Input.GetKey("q"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Force);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
            }
        }
        
    }*/
}




