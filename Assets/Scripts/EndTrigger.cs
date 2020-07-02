using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

            void OnTriggerEnter(Collider other)

             {

                 if (other.CompareTag("Player"))
    
                  gameManager.CompleteLevel();

             }
}
