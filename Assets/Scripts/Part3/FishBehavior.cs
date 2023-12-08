using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
   /* public int FishSpeed = 20;
     public Rigidbody2D rb;
     // Start is called before the first frame update
     void Start()
     {
         rb = gameObject.GetComponent<Rigidbody2D>();
     }

     // Update is called once per frame
     void Update()
     {
         rb.velocity = transform.right * 20;
     }*/
    public float speed = 0.5f;
    public Transform Player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Player.position, transform.position) > 1.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);

        }

    }

}
