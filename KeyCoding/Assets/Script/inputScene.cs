using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inputScene : MonoBehaviour {
    string selectedLevel, selectedLanguage;

	void Start () {
        textReader scanner = new textReader();
        scanner.textread();
	}

    void getValue(){

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private string textField = "";

    private void OnGUI()
    {
        textField = GUI.TextArea(new Rect(500, 11, 275, 295), textField);
    }
}
