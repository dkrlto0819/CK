using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marking : MonoBehaviour {

    Text scrollText;
    InputField input;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int checking(){
        scrollText = GameObject.Find("scrollText").GetComponent<Text>();
        input = GameObject.Find("InputField").GetComponent<InputField>();

        string example, answer;
        example = scrollText.text.Trim();
        example = example.Replace(" ", "");
        answer = input.text.Trim();
        answer = answer.Replace(" ", "");


        if (answer.Equals(example))
        {

            return 1;
        }
        else return 0;
    }
}
