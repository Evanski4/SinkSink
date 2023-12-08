using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class MoveWASDPt2 : MonoBehaviour
{
    public float Speed = 5f;
 

    // Start is called before the first frame update
    void Start()
    {
       transform.position = new Vector2 (-6.69f, 1.68f);
        //Rb = GetComponent<Rigidbody2D>();
        //MovementX = 0;
        //MovementY = 0;
        //fixedPoint = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        //Rb.velocity = new Vector2(MovementX * Speed * Time.deltaTime, MovementY * Speed * Time.deltaTime);


       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
          

        }
        if (Input.GetKey(KeyCode.D))
        {
            //MovementX = 1;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            

        }
        
       // if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        //{
          //  MovementX = 0;

        //}


    }







}
