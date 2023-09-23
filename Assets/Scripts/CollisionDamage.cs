using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage=1;
    public DamageReceiver playerReceiver;
    public ObjectDeletion objectDelete;
    public FloatingTextModifier floatingText;
    public string textToDisplay = "";
    private bool textDisplayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerReceiver.TakeDamage(damage);
            objectDelete.DeleteObject();
            if(floatingText && !textDisplayed)
            {
                floatingText.ChangeText(textToDisplay);
                textDisplayed = true;
            }
        }
    }
}
