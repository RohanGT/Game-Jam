using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBobbing : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 1.2f;
    private float lowerY = 0.6f, upperY = 1.4f;
    private float direction = 1;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y >= upperY) 
        {
            direction = -1;
        }
        else if (transform.position.y <= lowerY)
        {
            direction = 1;
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime * direction);

    }
}
