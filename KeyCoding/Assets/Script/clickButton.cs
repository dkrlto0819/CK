using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickButton : MonoBehaviour {

    Canvas resultCanvas;
	// Use this for initialization
	void Start () {
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickDoneButton(){

        resultCanvas.gameObject.SetActive(true);
    }

    public void ClickXButton(){
        //resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        resultCanvas.gameObject.SetActive(false);
    }
}
