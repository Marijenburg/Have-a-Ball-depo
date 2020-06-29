using UnityEngine;

public class Obstacleagainstbullet : MonoBehaviour
{

    public Rigidbody Obstacle;
    float force = 2f;
    public AudioSource crashSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force);
        }
        if (collision.collider.tag == "Player")
        {
            crashSound.Play();
        }

    }
}
