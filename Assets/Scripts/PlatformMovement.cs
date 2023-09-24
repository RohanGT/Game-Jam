using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.2f;
    public float rangeX = 1f;
    private float direction = 1;
    private float startX;

    private void Start()
    {
        startX = transform.position.x;
    }

    void FixedUpdate()
    {
        if (transform.position.x > startX+rangeX)
        {
            direction *= -1;
        }
        else if (transform.position.x < startX)
        {
            direction *= -1;
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime * direction);

    }
}
