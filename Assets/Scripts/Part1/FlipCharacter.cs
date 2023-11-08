using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            Rb.transform.localScale = new Vector2(-1, 1);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           
            Rb.transform.localScale = new Vector2(1, 1);

        }
    }
}
