using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public Rigidbody bullet;
    public float force = 50000f;
    //public TimeManager timeManager;
    


    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") 
        {
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force * Time.deltaTime,ForceMode.Impulse) ;
           //To call the function slowmotion : 
            //timeManager.DoSlowmotion();
        }
        if (collision.collider.tag == "Bullet") 
        {
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force * Time.deltaTime, ForceMode.Impulse);
        }

        
    }

    


    
 }
