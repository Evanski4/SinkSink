using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger entered");

        if (other.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
