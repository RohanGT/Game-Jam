using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{

    public int damage = 1;
    public DamageReceiver playerReceiver;
    public ObjectDeletion objectDelete;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerReceiver.TakeDamage(damage);
            objectDelete.DeleteObject();
        }
    }
}
