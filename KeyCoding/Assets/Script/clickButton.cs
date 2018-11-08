using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButton : MonoBehaviour {
    Canvas resultCanvas;
    Canvas messageBox;
    int flag=0;

	void Awake () {
        resultCanvas = GameObject.Find("ResultCanvas").GetComponent<Canvas>();
        messageBox = GameObject.Find("MessageBoxCanvas").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickDoneButton()
    {
        getDropdownValue dropdownValue = new getDropdownValue();
        inputScene input = new inputScene();
       // Text resultText = GameObject.Find("resultText").GetComponent<Text>();

        marking flagValue = new marking();
        flag = flagValue.checking();
        if (flag == 1)
        {

            dropdownValue.getStageValue();
            resultCanvas.gameObject.SetActive(true);
            input.ShowResult();
            flag = 0;
        }else{
            messageBox.gameObject.SetActive(true);
        }
    }

    public void ClickXButton(){
        resultCanvas.gameObject.SetActive(false);
    }

    public void ClickCloseButton(){
        messageBox.gameObject.SetActive(false);
    }
    
}
