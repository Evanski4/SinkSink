using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovePt2 : MonoBehaviour
{
    public float Speed = 5f;
    

    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }



    }

}

