using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingColumnScript : MonoBehaviour
{
    public float speedX = -3;
    public float width = 20.48f;

    private void Start()
    {
        float yRandom = Random.Range(0, 2.6f);
        transform.position = new Vector3(transform.position.x, yRandom, transform.position.z);
    }

    void Update()
    {
        float speedPPS = speedX * Time.deltaTime;
        transform.Translate(speedPPS, 0, 0);

        if (transform.position.x <= -width) 
        {
            transform.Translate(2*width, 0, 0);
            float yRandom = Random.Range(0, 2.6f);
            transform.position = new Vector3(transform.position.x, yRandom, transform.position.z);
        }
    }
}
