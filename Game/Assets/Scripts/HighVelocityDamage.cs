using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighVelocityDamage : MonoBehaviour
{
    public float dmgVelocity;
    public int damage = 1;
    public DamageReceiver playerReceiver;
    public ObjectDeletion objectDelete;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float velocity = gameObject.GetComponent<Rigidbody2D>().velocity.magnitude;
        if (collision.gameObject.tag == "Player" && velocity > dmgVelocity)
        {
            playerReceiver.TakeDamage(damage, objectDelete);
        }
    }
}
