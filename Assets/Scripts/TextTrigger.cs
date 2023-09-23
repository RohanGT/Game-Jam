using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    private bool textDisplayed = false;
    public string textToDisplay = "";
    public FloatingTextModifier playerText;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!textDisplayed && playerText && collision.gameObject.tag=="Player")
        {
            playerText.ChangeText(textToDisplay);
            textDisplayed = true;
        }
    }
}
