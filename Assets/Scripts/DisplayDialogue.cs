using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDialogue : MonoBehaviour
{
    private string dialogueText = "Hello, Player!"; // The text you want to display.
    public GameObject dialogueBox; // Reference to the dialogue box GameObject.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player has entered the trigger zone.
        {
            dialogueBox.GetComponentInChildren<UnityEngine.UI.Text>().text = dialogueText;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player has exited the trigger zone.
        {
            // Disable the dialogue box when the player exits the trigger zone.
            dialogueBox.SetActive(false);
        }
    }
}
