using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputScene : MonoBehaviour {
    string selectedLevel, selectedLanguage;
    Text ScrollText;
    Canvas resultCanvas;
    Canvas messageBox;
    Canvas inputDataBox;
    InputField input;

	void Start () {
        textReader scanner = new textReader();
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        messageBox = GameObject.Find("MessageBoxCanvas").GetComponent<Canvas>();
        inputDataBox = GameObject.Find("InputdataBox").GetComponent<Canvas>();

        resultCanvas.gameObject.SetActive(false);
        messageBox.gameObject.SetActive(false);
        inputDataBox.gameObject.SetActive(false);

        input = GameObject.Find("InputField").GetComponent<InputField>();

        scanner.SecondSceneDropdownTextread();
        //AddTextToScroll();
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            input.text += "\n";
            Debug.Log(KeyCode.Return);
            //input.text = input.text.Replace("Return", "\n");
        }
    }


    //public void AddTextToScroll()
    //{
    //    textReader fillExample = new textReader();
    //    fillExample.SecondSceneDropdownTextread();
    //}
}
