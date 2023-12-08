using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towardsCenter : MonoBehaviour
{
    [SerializeField] private GameObject drain;
    [SerializeField] private float speed = 1.5f;
    public Boolean isBouncing = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position,drain.transform.position,speed*Time.deltaTime);
    }

}
