using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger entered");

        if (other.tag == "Player1" || other.tag == "Player2")
        {
            SceneManager.LoadScene(2);
        }
    }
}