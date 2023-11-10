using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   void onTriggerEnter2D(Collider2D enemy)
   {
    if(enemy.tag == "Enemy")
    {
        enemy.transform.Rotate(0f,180f,0f);
        
    }
   }
}
