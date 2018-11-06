using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class textReader : MonoBehaviour {

    Scrollbar example;
    Dropdown dropdown;
    string basicPath = "Assets/Textfile/";

    void Start()
    {
        Dropdown dropdown1 = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        dropdown1.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown1);
        });
    }

    public void SecondSceneDropdownTextread(){
        int counter = 0;
        string filename = "1";
        string line;
        dropdown = GameObject.Find("StageContent").GetComponent<Dropdown>();

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/"+"level/"+saveValue.level+".txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = line });
            counter++;
        }

        fileScanner.Close();
    }

    //public void CallExampleFile(){
    //    string line;
    //    Text scrollText = GameObject.Find("scrollText").GetComponent<Text>();
    //    System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/example/" + saveValue.language + "/2.txt");
    //    while ((line = fileScanner.ReadLine()) != null)
    //    {
    //        scrollText.text += line + "\n";
    //    }

    //    fileScanner.Close();
    //}

    public void DropdownValueChanged(Dropdown change){
        string line;
        Text scrollText = GameObject.Find("scrollText").GetComponent<Text>();

        scrollText.text = "";

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/example/" + saveValue.language + "/" + saveValue.level + "/" + change.value+ ".txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            scrollText.text += line + "\n";
        }

        fileScanner.Close();
    }


}
