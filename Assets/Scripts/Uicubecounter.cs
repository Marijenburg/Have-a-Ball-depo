
using UnityEngine;
using UnityEngine.UI;

public class Uicubecounter : MonoBehaviour
{
    public RawImage cube1; 
    public RawImage cube2;  
    public RawImage cube3;
    public RawImage cube4;
    public RawImage cube5;
    public RawImage cube6;
    public RawImage cube7;
    public RawImage cube8;
    public RawImage cube9;
    public RawImage cube10;
    public Animator cuben1;
    public Animator cuben2;
    public Animator cuben3;
    public Animator cuben4;
    public Animator cuben5;
    public Animator cuben6;
    public Animator cuben7;
    public Animator cuben8;
    public Animator cuben9;
    public Animator cuben10;



    public static double numberOfCubes = 0;

    // Start is called before the first frame update

   
    // Update is called once per frame
    void Update()
    {
        cuben1.enabled = false;
        cuben2.enabled = false;
        cuben3.enabled = false;
        cuben4.enabled = false;
        cuben5.enabled = false;
        cuben6.enabled = false;
        cuben7.enabled = false;
        cuben8.enabled = false;
        cuben9.enabled = false;
        cuben10.enabled = false;


        if (numberOfCubes == 1)
        {
                    
            cube1.enabled = true;
            cuben1.enabled = true;
        }
        if (numberOfCubes == 2)
        {
            cube1.enabled = true;
            cube2.enabled = true;           
            cuben2.enabled = true;
        }
        if (numberOfCubes == 3)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cuben3.enabled = true;
        }
        if (numberOfCubes ==4)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cuben4.enabled = true;
        }
        if (numberOfCubes == 5)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cube5.enabled = true;
            cuben5.enabled = true;
        }
        if (numberOfCubes == 6)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cube5.enabled = true;
            cube6.enabled = true;
            cuben6.enabled = true;
        }
        if (numberOfCubes == 7)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cube5.enabled = true;
            cube6.enabled = true;
            cube7.enabled = true;
            cuben7.enabled = true;
        }
        if (numberOfCubes == 8)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cube5.enabled = true;
            cube6.enabled = true;
            cube7.enabled = true;
            cube8.enabled = true;
            cuben8.enabled = true;
        }
        if (numberOfCubes == 9)
        {
            cube1.enabled = true;
            cube2.enabled = true;
            cube3.enabled = true;
            cube4.enabled = true;
            cube5.enabled = true;
            cube6.enabled = true;
            cube7.enabled = true;
            cube8.enabled = true;
            cube9.enabled = true;
            cuben9.enabled = true;
        }
        if (numberOfCubes == 10)
        {
            cube1.enabled = false;
            cube2.enabled = false;
            cube3.enabled = false;
            cube4.enabled = false;
            cube5.enabled = false;
            cube6.enabled = false;
            cube7.enabled = false;
            cube8.enabled = false;
            cube9.enabled = false;
            cube10.enabled = false;
            cuben10.enabled = true;
            Lifecounter.numberoflives +=1;
            numberOfCubes = 0;
        }


    }
        
}
