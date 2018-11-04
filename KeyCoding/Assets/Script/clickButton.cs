using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickButton : MonoBehaviour {
    Canvas resultCanvas;

	void Awake () {
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickDoneButton(){
        resultCanvas.gameObject.SetActive(true);
    }

    public void ClickXButton(){
        resultCanvas.gameObject.SetActive(false);
    }
}
