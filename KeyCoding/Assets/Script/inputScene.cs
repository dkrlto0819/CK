using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class inputScene : MonoBehaviour {
    //string selectedLevel, selectedLanguage;

    textReader scanner;

    //Text ScrollText;
    Canvas resultCanvas;
    Canvas messageBox;
    Canvas inputDataBox;
    Canvas solutionCanvas;
    InputField input;
    //Canvas scrollCanvas;
    int count, left, right;

    string result;

    Text resultText;

    void Start () {

        count = 0;

        scanner=new textReader();
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        messageBox = GameObject.Find("MessageBoxCanvas").GetComponent<Canvas>();
        inputDataBox = GameObject.Find("InputdataBox").GetComponent<Canvas>();
        solutionCanvas = GameObject.Find("SolutionCanvas").GetComponent<Canvas>();

        //resultText = GameObject.Find("resultText").GetComponent<Text>();
       // scrollCanvas = GameObject.Find("scrollCanvas").GetComponent<Canvas>();

        resultCanvas.gameObject.SetActive(false);
        messageBox.gameObject.SetActive(false);
        inputDataBox.gameObject.SetActive(false);
        solutionCanvas.gameObject.SetActive(false);

        input = GameObject.Find("InputField").GetComponent<InputField>();
        scanner.SecondSceneDropdownTextread();
        //AddTextToScroll();
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int inputLength=0;
            string inputValue = input.text.Replace("\n", "");
            inputValue = inputValue.Replace(" ", "");
            inputLength = inputValue.Length;

            Debug.Log(inputValue.Substring(inputLength));
            if (input.text.Substring(inputLength).Contains("}")) {
                int lastIndex=input.text.LastIndexOf("}");
                //int lastIndex = inputValue.LastIndexOf("}");
                //Debug.Log(lastIndex);

                if (input.text.Substring(lastIndex - 5).Contains(";"))
                {
                    //int lastIndex = inputValue.LastIndexOf("}");
                    Debug.Log("Hi");
                    int lastIndexforSemi = input.text.LastIndexOf(";");
                    Debug.Log(input.text.Substring(lastIndexforSemi));
                    input.text = input.text.Substring(0, lastIndex-3)+"\n";
                    for (int i = 1; i <= count-1; i++) input.text += "\t";
                    input.text += "}\n";
                }
                 
            }
            System.Text.RegularExpressions.Regex cntStr = new System.Text.RegularExpressions.Regex("{");
            left = int.Parse(cntStr.Matches(inputValue, 0).Count.ToString());
            System.Text.RegularExpressions.Regex cntStr2 = new System.Text.RegularExpressions.Regex("}");
            right = int.Parse(cntStr2.Matches(inputValue, 0).Count.ToString());

            count=left-right;
            //input.text += "\n";
            //Debug.Log("\t" + count);
            for (int i = 1; i <= count; i++)
            {
                input.text += "\t";
            }
            input.caretPosition = input.text.Length;
        }
    }
    public void ShowResult(){
        level2stage1 level2stage1 = new level2stage1();
        Text resultText = GameObject.Find("resultText").GetComponent<Text>();
        Debug.Log("Hello!");
        //resultText.text = "hello!";

        resultText.text = "\n";
        scanner = new textReader();
        scanner.ReadResultFile();

        resultText.text += saveValue.resultFile;
        saveValue.resultFile = "";
    }


    //public void AddTextToScroll()
    //{
    //    textReader fillExample = new textReader();
    //    fillExample.SecondSceneDropdownTextread();
    //}
}
