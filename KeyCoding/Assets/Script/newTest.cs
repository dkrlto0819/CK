using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        TestScene();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TestScene()
    {
        string line;

        //InputField input = GameObject.Find("InputField").GetComponent<InputField>();
        Text text = GameObject.Find("1").GetComponent<Text>();
        text.text = "\n\n";
        //input.text = "";

        int i = 1;

        //System.IO.StreamReader fileScanner = new System.IO.StreamReader(@"Assets/Textfile/example/" + saveValue.language + "/" + saveValue.level + "/" + change.value + ".txt");
        //while ((line = fileScanner.ReadLine()) != null && i!=5)
        while (i != 5)
        {
            string name = i.ToString();
            text = GameObject.Find(name).GetComponent<Text>();
            text.text = "";
            text.text += "Hello!" + "\n";
            i += 2;
        }
    }
}
