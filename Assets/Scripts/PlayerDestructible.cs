using UnityEngine;

public class PlayerDestructible : MonoBehaviour
{

    public GameObject playerDestroyed;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            
            Instantiate(playerDestroyed, transform.position, transform.rotation);
            Destroy(gameObject);
            SoundManager.PlaySound("crash");
        }
       
    }
}