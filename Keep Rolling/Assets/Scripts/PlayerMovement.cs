using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //On crée un slot pour le rigidbody, on l'appelle rb puis dans unity on le glisse dedans

    public LayerMask groundLayers;
    public Rigidbody rb;
    public float forwardForce = 40f;
    public float sidewaysForce = 25f;
    public float forwardInair = 300f;
    public float sidewaysInair = 300f;
    public float jumpForce = 12f;
    public SphereCollider col;
    public float sideForceController = 2f;
    public float sideAirForceController = 1f;



    // Update is called once per frame
    void FixedUpdate()
    {
        Cursor.visible = false;
        //move sideways with controller
        if (IsGrounded())
        {
            Debug.Log(sidewaysForce * Input.GetAxis("Horizontal") * Time.deltaTime );
            rb.AddForce(sidewaysForce * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f,ForceMode.Impulse);
        }
        else
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            rb.AddForce(sidewaysInair * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f,ForceMode.Acceleration);
        }
             
        // the force that pushes straight forward
        if (IsGrounded())
            {
            rb.AddForce(0, 0, forwardForce, ForceMode.Force);
        }
        else
            {
            rb.AddForce(0, 0, forwardInair, ForceMode.Force);
        }
                    
        
        //go right arrows
        if (IsGrounded())
          {
              
              if (Input.GetKey(KeyCode.RightArrow))
                {
              rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.Impulse);

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
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);

            }
        }
        else
          if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }
        //go left arrows
        if (IsGrounded())
          { 
              if (Input.GetKey(KeyCode.LeftArrow))
            {
              rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
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
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-sidewaysInair * Time.deltaTime, 0, 0, ForceMode.Acceleration);
            }
        }

        //jump

        if (IsGrounded() && Input.GetKey(KeyCode.Space))

          {
              rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          }
        //jump with controller
      if (IsGrounded() && Input.GetKey(KeyCode.Joystick1Button0))

      {
          rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      }
      
      
        if (rb.position.y < -10f)
          {
              FindObjectOfType<GameManager>().EndGame();
          }
          
         
    }

    //to check if grounded
    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
                col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);

    }
}




