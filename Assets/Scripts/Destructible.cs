using UnityEngine;

public class Destructible : MonoBehaviour
{
    
    public GameObject destroyedVersion;
    
    

    void OnCollisionEnter(Collision collisionInfo)
    {
      
        if (collisionInfo.collider.tag == "Bullet")
        {
           
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
            Uicubecounter.numberOfCubes  += 0.5 ;
            
        }
        
        if (collisionInfo.collider.tag == "Player")
        {
            
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
            Uicubecounter.numberOfCubes += 0.5;
            
        }
        
    }

}
