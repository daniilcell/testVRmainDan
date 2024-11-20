using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AnkateScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameText;
    public TMP_InputField ageInputField;
    public TMP_Text ageText;
    public TMP_InputField birthInputField;
    public TMP_Text ageOldText;

    private void Start() {
        nameInputField.onEndEdit.AddListener(NameInputFieldOnEndEdit);
        ageInputField.onEndEdit.AddListener(AgeInputFieldOnEndEdit);
    }

    private void NameInputFieldOnEndEdit(string text) {
     Debug.Log("AnketaScript::NameInputFieldOnEndEdit(); -- text" + text);
     OnButtonUserName();
    } 
    
    private void AgeInputFieldOnEndEdit(string text) {
      Debug.Log("AnketaScript::AgeInputFieldOnEndEdit(); -- text" + text);
       OnButtonUserAge();
    }

    public void OnButtonUserName() {
        Debug.Log("AnketaScript::NameInputFieldOnEndEdit(); -- text" + nameInputField.text);
        nameText.text = nameInputField.text;
    }

    public void OnButtonUserAge() {
        Debug.Log("AnketaScript::AgeInputFieldOnEndEdit(); -- text:" + ageInputField.text);
        string ageString = ageInputField.text;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) {
                //int ageInt = int.Parse(ageString);
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddYears(-ageInt);
                ageText.text = dateTime.ToString("yyyy");
            } else {
                ageText.text = "Need a number row";
            }
        } else {
            ageText.text = "This shouldn't be empty";
        }
    }

    public void OnButtonUserBirthAge() {
        Debug.Log("AnketaScript::AgeInputFieldOnEndEdit(); -- text:" + ageInputField.text);
        string ageString = ageInputField.text;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) {
                //int ageInt = int.Parse(ageString);
                DateTime dateTime = DateTime.Now;
                dateTime = dateTime.AddYears(-ageInt);
                ageText.text = dateTime.ToString("yyyy");
            } else {
                ageText.text = "Need a number row";
            }
        } else {
            ageText.text = "This shouldn't be empty";
        }
    }
}
