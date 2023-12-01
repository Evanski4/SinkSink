using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts2 : MonoBehaviour
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
        if (Lives1.p2Lives == 2) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = twoLives;
            print("ran");
        }
        else if (Lives1.p2Lives == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = oneLife;
        }
        DontDestroyOnLoad(this);
    }
}
