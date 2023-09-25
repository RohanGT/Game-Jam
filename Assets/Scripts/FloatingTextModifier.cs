using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingTextModifier : MonoBehaviour
{
    // Start is called before the first frame update
    private string currentText = "";
    public void ChangeText(string txt)
    {
        gameObject.GetComponent<TMP_Text>().text = txt;
        if (currentText != txt)
        {
            StartCoroutine(ChangeTextCoroutine(txt));
        }
    }

    private void ClearText()
    {
        gameObject.GetComponent<TMP_Text>().text = "";
    }

    private IEnumerator ChangeTextCoroutine(string txt)
    {
        currentText = txt;
        yield return new WaitForSeconds(2.5f);
        if (txt == currentText)
        {
            gameObject.GetComponent<TMP_Text>().text = "";
        }
    }
}
