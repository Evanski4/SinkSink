using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeath : MonoBehaviour
{
    private string nextSceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            SceneManager.LoadScene(3);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
