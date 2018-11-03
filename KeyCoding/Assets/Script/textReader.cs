using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class textReader : MonoBehaviour {

    Scrollbar example;
    Dropdown dropdown;
    string basicPath = "Assets/Textfile/";


    public void SecondSceneDropdownTextread(){
        int counter = 0;
        string filename = "level1.txt";
        string line;
        List<string> DropOptions = new List<string> { "Option 1", "Option 2" };
        Dropdown dropdown = GameObject.Find("StageContent").GetComponent<Dropdown>();

        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/"+filename);
        while ((line = fileScanner.ReadLine()) != null)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = line });
            Debug.Log(line);
            counter++;
        }

        fileScanner.Close();
    }

    public void CallExampleFile(){
        string line;
        Text scrollText = GameObject.Find("scrollText").GetComponent<Text>();
        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/" + "gugudan.txt");
        while ((line = fileScanner.ReadLine()) != null)
        {
            scrollText.text += line + "\n";
            Debug.Log(line);
        }

        fileScanner.Close();
    }


}
