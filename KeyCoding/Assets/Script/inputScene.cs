using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputScene : MonoBehaviour {
    //string selectedLevel, selectedLanguage;

    textReader scanner;

    //Text ScrollText;
    Canvas resultCanvas;
    Canvas messageBox;
    Canvas inputDataBox;
    InputField input;
    //Canvas scrollCanvas;

    string result;

    Text resultText;

	void Start () {


        scanner=new textReader();
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        messageBox = GameObject.Find("MessageBoxCanvas").GetComponent<Canvas>();
        inputDataBox = GameObject.Find("InputdataBox").GetComponent<Canvas>();
        //resultText = GameObject.Find("resultText").GetComponent<Text>();
       // scrollCanvas = GameObject.Find("scrollCanvas").GetComponent<Canvas>();

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
            //input.text = input.text.Replace("Return", "\n");
        }
    }
    public void ShowResult(){
        level2stage1 level2stage1 = new level2stage1();
        Text resultText = GameObject.Find("resultText").GetComponent<Text>();
        Debug.Log("Hello!");
        //resultText.text = "hello!";

        resultText.text = "";
        scanner = new textReader();
        scanner.ReadResultFile();

        resultText.text = saveValue.resultFile;
        saveValue.resultFile = "";

        //if (saveValue.level.Equals("0")){
        //    Debug.Log(saveValue.resultFile);
        //    resultText.text = saveValue.resultFile;
        //    saveValue.resultFile = "";
        //}else if(saveValue.level.Equals("1")){
        //    if(saveValue.stage.Equals("1")){
        //        level2stage1.Doit();
        //    }
        //}

    }


    //public void AddTextToScroll()
    //{
    //    textReader fillExample = new textReader();
    //    fillExample.SecondSceneDropdownTextread();
    //}
}
