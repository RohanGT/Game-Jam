using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    private int maxHealth = 100;
    private int currHealth;
    private bool isInvincible = false;
    private float invicibilityDuration = 1f;
    private float invincibilityDeltaTime = 0.1f;

    public HealthModifier healthBar;

    public GameObject model;

    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // For player flashing effect
    private void ScaleModelTo(Vector3 scale) 
    {
        model.transform.localScale = scale;
    }

    // I-Frame calculation on taking damage
    private IEnumerator InvincibilityFrame()
    {
        Debug.Log("I-frame");
        isInvincible = true;

        // Generating multiple I-frames
        for(float i = 0; i<invicibilityDuration; i+= invincibilityDeltaTime) 
        {
            if (model.transform.localScale == Vector3.one) ScaleModelTo(Vector3.zero); // Hiding player
            else ScaleModelTo(Vector3.one); // Restoring player

            yield return new WaitForSeconds(invincibilityDeltaTime);
        }

        ScaleModelTo(Vector3.one); // To prevent player disappearing with 0 scale
        isInvincible = false;
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible) return;

        currHealth -= damage;
        healthBar.SetHealth(currHealth);

        if(currHealth<= 0)
        {
            //model.transform.Rotate(new Vector3(0, 0, 90)); // PENDING: Create another class? Probably replace with actual player so collider rotates.
            Debug.Log("Game Over!");
            return;
        }

        StartCoroutine(InvincibilityFrame());
    }
}
