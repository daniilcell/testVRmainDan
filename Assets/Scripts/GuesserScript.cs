using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
public class GuesserScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField0;
    [SerializeField] private TMP_Text userOutText;
    private int rand;
    private void Start() {
        RandomNumber();
    }
    private void RandomNumber() {
        rand = Random.Range(0, 101);
    }
    public void OnButton() {
        int userNumber = ReadInt(inputField0);
        if (userNumber == rand) {
            userOutText.text = "You are right! Restarting... ";
            RandomNumber();
        } else if (rand < userNumber) {
            userOutText.text = "Number is smaller";
        } else {
            userOutText.text = "Number is bigger";
        }
    }
    private int ReadInt(TMP_InputField inputField){
        string str = inputField.text;
        if (str != null && str.Length > 0 ) {
            if (int.TryParse(str, out int intValue)) {
                return intValue;
            }
        }
        return 0;
    }
}
