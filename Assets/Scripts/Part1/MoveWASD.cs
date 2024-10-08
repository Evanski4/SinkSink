using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour
{
    public float Speed;
    Vector2 movement;
    float MovementX;
    float MovementY;
    //Boolean isBouncing = false;

    private Vector2 fixedPoint;
    private float currentAngle;

    Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        MovementX = 0;
        MovementY = 0;
        fixedPoint = transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.velocity = new Vector2(MovementX * Speed * Time.fixedDeltaTime, MovementY * Speed * Time.fixedDeltaTime);


        if (Input.GetKey(KeyCode.W))
        {
            MovementY = 1;

        }
        if (Input.GetKey(KeyCode.S))
        {
            MovementY = -1;

        }
        if (Input.GetKey(KeyCode.A))
        {
            MovementX = -1;

        }
        if (Input.GetKey(KeyCode.D))
        {
            MovementX = 1;

        }
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            MovementY = 0;

        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            MovementX = 0;

        }

        
    }
 
 
    
    
  


}