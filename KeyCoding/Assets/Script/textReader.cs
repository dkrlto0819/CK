using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class textReader : MonoBehaviour {

    Dropdown dropdown = GameObject.Find("StageContent").GetComponent<Dropdown>();
    string basicPath = "Assets/Textfile/";


    public void textread(){
        int counter = 0;
        string filename = "level1.txt";
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/"+filename);
        while ((line = fileScanner.ReadLine()) != null)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = line });
            Debug.Log(line);
            counter++;
        }

        fileScanner.Close();
    }


}
