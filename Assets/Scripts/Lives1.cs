using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives1 : MonoBehaviour
{
    public static int p1Lives = 3;
    public static int p2Lives = 3;
    private bool hasRun = false;

    // Start is called before the first frame update
    void Start()
    {
        print("Both lives = 3");
        hasRun = false;
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
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
            else if(other.tag == "Lose2" && this.tag == "Player1")
            {
                p1Lives -= 1;
                hasRun = true;
            }
            else if (other.tag == "Lose2" && this.tag == "Player2")
            {
                p2Lives -= 1;
                hasRun = true;
            }
        }
        /*
        if(currentSceneName == "part2")
        {
            if (other.tag == "Lose" && this.tag == "Player1")
            {
                p1Lives -= 1;
                print("p1 lives -1");
                print("p1 lives: " + p1Lives);
                
            }
            else if (other.tag == "Lose" && this.tag == "Player2")
            {
                p2Lives -= 1;
                print("p2 lives -1");
                print("p2 lives: " + p2Lives);
                
            }
        }
        */
        
    }

    //Add part2 Lose condition

}
