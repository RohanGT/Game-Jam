using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ObjectDeletion : MonoBehaviour
{
    private List<GameObject> keepTrack= new List<GameObject>();
    
    void Start()
    {
        foreach(Transform child in gameObject.transform)
        {
            keepTrack.Add(child.gameObject);
        }
    }
    public void DeleteObject()
    {
        try
        {
            if(keepTrack.Count > 0)
            {
                int number = Random.Range(0, keepTrack.Count);
                Destroy(keepTrack[number]);
                keepTrack.RemoveAt(number);
            }
        }
        catch (Exception ex)
        {
            print("Deletion Error: " + ex.Message);
        }
    }

}
