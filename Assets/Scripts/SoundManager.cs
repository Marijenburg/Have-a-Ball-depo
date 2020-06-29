using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip ballrollingsound, ballcrashsound, jumpsound, landingsound, powerupsound;
    static AudioSource audioSrc;
    
   
    // Start is called before the first frame update
    void Start()
    {
        ballrollingsound = Resources.Load<AudioClip>("ballrolling");
        ballcrashsound = Resources.Load<AudioClip>("crash");
        jumpsound = Resources.Load<AudioClip>("jump");
        landingsound = Resources.Load<AudioClip>("landing");
        powerupsound = Resources.Load<AudioClip>("powerup");       
        audioSrc = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound (string clip)
  {
        switch (clip)
        {
            case "crash":
                audioSrc.PlayOneShot(ballcrashsound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpsound);
                break;
            case "landing":
                audioSrc.PlayOneShot(landingsound);
                break;
            case "powerup":
                audioSrc.PlayOneShot(powerupsound);
                break;
            case "ballrolling":
                audioSrc.PlayOneShot(ballrollingsound);
                break;
            

        }
}
   
    }
