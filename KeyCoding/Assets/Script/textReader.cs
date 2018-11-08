using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class textReader : MonoBehaviour {

    Text resultText;
    Scrollbar example;
    Dropdown dropdown;
    string basicPath = "Assets/Textfile/";

    void Start()
    {
        Dropdown dropdown1 = GameObject.Find("StageContent").GetComponent<Dropdown>();
        dropdown1.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown1);
        });

    }

    public void Awake()
    {
        resultText = GameObject.Find("resultText").GetComponent<Text>();
    }

    public void SecondSceneDropdownTextread(){
        int counter = 0;
        string filename = "1";
        string line;
        dropdown = GameObject.Find("StageContent").GetComponent<Dropdown>();

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/level/"+saveValue.level+".txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = line });
            counter++;
        }

        fileScanner.Close();
    }

    public void DropdownValueChanged(Dropdown change){
        string line;
        Text scrollText = GameObject.Find("scrollText").GetComponent<Text>();
        InputField input = GameObject.Find("InputField").GetComponent<InputField>();

        scrollText.text = "";
        input.text = "";

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/example/" + saveValue.language + "/" + saveValue.level + "/" + change.value+ ".txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            scrollText.text += line + "\n";
        }

        fileScanner.Close();
    }

    public void ReadResultFile(){
        string line;
        //string resultFile="";
        //resultText.text = "";
        //input.text = "";
        Text result = GameObject.Find("resultText").GetComponent<Text>();
        //Text result = GameObject.Find("resultText").GetComponent<Text>();

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/result/0/" + saveValue.level + "/" + saveValue.stage + ".txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            //result.text += line + "\n";
            saveValue.resultFile += line + "\n";
        }

        fileScanner.Close();
    }


}
