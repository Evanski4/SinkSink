using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rb.transform.localScale = new Vector2(1, 1);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rb.transform.localScale = new Vector2(-1, 1);

        }
    }
}
