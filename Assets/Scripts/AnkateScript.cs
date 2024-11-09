using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnkateScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameText;
    public TMP_InputField ageInputField;
    public TMP_Text ageText;
    public void OnButtonUserName()
    {
        nameText.text = nameInputField.text;
    }

// https://www.google.ru/
    public void OnButtonUserAge()
    {
        string ageString = ageInputField.text;
        int ageInt = int.Parse(ageString)

    }
}
