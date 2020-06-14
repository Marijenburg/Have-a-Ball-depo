using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int theScore;

    // Update is called once per frame
    void update()
    {
        theScore += 1;
        scoreText.text = "Cube" +theScore;
    }


}


