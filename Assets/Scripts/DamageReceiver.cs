using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    private int maxHealth = 100;
    private int currHealth;

    public HealthModifier healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(10);

    }

    private void TakeDamage(int damage)
    {
        currHealth -= damage;
        healthBar.SetHealth(currHealth);
    }
}
