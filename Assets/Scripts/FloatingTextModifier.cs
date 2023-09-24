using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingTextModifier : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeText(string txt)
    {
        gameObject.GetComponent<TMP_Text>().text = txt;
        Invoke("ClearText", 2.5f);
    }

    private void ClearText()
    {
        gameObject.GetComponent<TMP_Text>().text = "";
    }
}
