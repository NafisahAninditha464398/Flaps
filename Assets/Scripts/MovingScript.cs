using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speedX = -2;
    public float width = 20.48f;
    
    void Update()
    {
        float speedPPS = speedX * Time.deltaTime;
        transform.Translate(speedPPS, 0, 0);

        if (transform.position.x <= -20.48) {
            transform.Translate(width, 0, 0);
        }
    }
}
