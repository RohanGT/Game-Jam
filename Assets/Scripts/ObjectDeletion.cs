using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ObjectDeletion : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject wallObject;
    private List<GameObject> keepTrack= new List<GameObject>();
    
    void Start()
    {
        wallObject = GameObject.FindWithTag("WallObj");
        foreach(Transform child in wallObject.transform)
        {
            keepTrack.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        try
        {
            int number = Random.Range(0, keepTrack.Count);
            if (col.gameObject.name == "Player")
            {
                Destroy(keepTrack[number]);
                keepTrack.RemoveAt(number);
            }
        }
        catch(Exception ex)
        {
            print("Error");
        }
    }
}
