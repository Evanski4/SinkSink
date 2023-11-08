using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public Sprite twoLives;
    public Sprite oneLife;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if (Lives1.p1Lives == 2) //access static variable??
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = twoLives;
        }
        else if(Lives1.p1Lives == 1) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = oneLife;
        }
    }
}
