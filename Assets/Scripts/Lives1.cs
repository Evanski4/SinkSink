using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives1 : MonoBehaviour
{
    public static int p1Lives;
    public static int p2Lives;
    // Start is called before the first frame update
    void Start()
    {
        p1Lives = 3;
        p2Lives = 3;
        print("Both lives = 3");
    }

    private bool hasRun = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasRun)
        {
            //Part 1
            if (other.tag == "Lose" && this.tag == "Player1")
            {
                p1Lives -= 1;
                print("p1 lives -1");
                print("p1 lives: " +  p1Lives);
                hasRun = true;
            }
            else if (other.tag == "Lose" && this.tag == "Player2")
            {
                p2Lives -= 1;
                print("p2 lives -1");
                print("p2 lives: " + p2Lives);
                hasRun = true;
            }
        }
    }

    //Add part2 Lose condition

}
