using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrows : MonoBehaviour
{
    public float Speed;
    public Boolean isBouncing;
    float MovementX;
    float MovementY;

    Rigidbody2D Rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        MovementX = 0;
        MovementY = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.velocity = new Vector2(MovementX * Speed * Time.fixedDeltaTime, MovementY * Speed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovementY = 1;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovementY = -1;
            
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovementX = -1;
            

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovementX = 1;
            

        }

        
        
        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            MovementY = 0;

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            MovementX = 0;

        }
        
       


    }

}
