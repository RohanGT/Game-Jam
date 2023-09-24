using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    //private float startX;
    // Start is called before the first frame update
    void Start()
    {
        //startX = player.transform.position.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //float moveForward = player.transform.position.x - startX;
        if (player.transform.position.x > 0)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(0, 0, transform.position.z);
        }
    }
}
