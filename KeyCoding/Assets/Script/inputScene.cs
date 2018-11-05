using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputScene : MonoBehaviour {
    string selectedLevel, selectedLanguage;
    Text ScrollText;
    Canvas resultCanvas;

	void Start () {
        textReader scanner = new textReader();
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        resultCanvas.gameObject.SetActive(false);
        scanner.SecondSceneDropdownTextread();
        //AddTextToScroll();
	}
	
	void Update () {
		
	}

    //public void AddTextToScroll()
    //{
    //    textReader fillExample = new textReader();
    //    fillExample.SecondSceneDropdownTextread();
    //}
}
