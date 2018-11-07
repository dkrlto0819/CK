using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enterKey : MonoBehaviour {
    InputField input;

    // Use this for initialization
    void Awake () {
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    void OnGUI()
    {
        GUI.skin.textField.wordWrap = true;
    }

    // Update is called once per frame

}
