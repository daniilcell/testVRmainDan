using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnkateScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameText;
         
    public void OnButtonUserName()
    {
        nameText.text = nameInputField.text;
    }
}
