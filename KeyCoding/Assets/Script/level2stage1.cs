using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2stage1 : MonoBehaviour {
    Canvas inputBox;
    Text label;
	// Use this for initialization
	void Start () {
        inputBox = GameObject.Find("InputdataBox").GetComponent<Canvas>();
        label = GameObject.Find("question").GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Doit(){
        label.text = saveValue.resultFile;
        inputBox.gameObject.SetActive(true);
    }
}
