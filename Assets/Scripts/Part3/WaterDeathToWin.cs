using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WaterDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player1")
        {
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Lives1.p1Lives == 0)
        {
            SceneManager.LoadScene("Player2Wins");
        }
        else if (Lives1.p2Lives == 0)
        {
            SceneManager.LoadScene("Player1Wins");
        }
    }
}
