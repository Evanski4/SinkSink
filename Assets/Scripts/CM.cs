using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour
{
    public float angularSpeed = 4f;
    public float circleRad = 10f;
    //public float circleRadShrink = 1f;

    private Vector2 fixedPoint;
    private float currentAngle;

    void Start()
    {
        fixedPoint = transform.position;
    }

    void Update()
    {
        if(circleRad <= 0)
        {
            End();
        }
        currentAngle += angularSpeed * Time.deltaTime;
        circleRad -= .01f;
        Vector2 offset = new Vector2(Mathf.Sin(currentAngle), Mathf.Cos(currentAngle)) * circleRad;
        transform.position = fixedPoint + offset;
    }

    void End()
    {
        angularSpeed = 0;
        circleRad = 0;
 
    }

}
