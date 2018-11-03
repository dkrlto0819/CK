using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputScene : MonoBehaviour {
    string selectedLevel, selectedLanguage;
    Text ScrollText;

	void Start () {
        textReader scanner = new textReader();
        scanner.SecondSceneDropdownTextread();
        AddTextToScroll();
	}
	
	void Update () {
		
	}

    private string textField = "";

    private void OnGUI()
    {
        textField = GUI.TextArea(new Rect(500, 11, 275, 295), textField);
    }

    public void AddTextToScroll()
    {
        textReader fillExample = new textReader();
        fillExample.CallExampleFile();
    }
}
