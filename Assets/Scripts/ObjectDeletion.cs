using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ObjectDeletion : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject wallObject;
    private GameObject deleteObject;
    private List<GameObject> keepTrack= new List<GameObject>();
    private List<GameObject> keepTrack1 = new List<GameObject>();
    void Start()
    {
        wallObject = GameObject.FindWithTag("WallObj");
        foreach(Transform child in wallObject.transform)
        {
            keepTrack.Add(child.gameObject);
        }
        deleteObject = GameObject.FindWithTag("DeleteObj");
        foreach (Transform child in deleteObject.transform)
        {
            keepTrack1.Add(child.gameObject);
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
            int number = Random.Range(0, keepTrack1.Count);
            if (col.gameObject.name == "Player")
            {
                Destroy(keepTrack1[number]);
                keepTrack1.RemoveAt(number);
            }
        }
        catch(Exception ex)
        {
            print("Error");
        }
    }
}
