using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class bounce1 : MonoBehaviour
{

    Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D Player2)
    {
        rb.AddForce(Player2.contacts[0].normal * 5000);
        //rb.AddForce(transform.transform      * 600);
    }



}
