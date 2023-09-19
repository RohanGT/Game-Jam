using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ObjectDeletion : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject deleteParent;
    private List<GameObject> keepTrack= new List<GameObject>();
    
    void Start()
    {
        deleteParent = GameObject.FindWithTag("DeleteParent");
        foreach(Transform child in deleteParent.transform)
        {
            keepTrack.Add(child.gameObject);
        }
    }
    public void DeleteObject()
    {
        try
        {
            int number = Random.Range(0, keepTrack.Count);
            Destroy(keepTrack[number]);
            keepTrack.RemoveAt(number);
        }
        catch (Exception ex)
        {
            print("Deletion Error: " + ex.Message);
        }
    }

}
