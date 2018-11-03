using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getDropdownValue : MonoBehaviour {
    Dropdown value_Dropdown;

    public string Level, Language;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void getLevelValue(){
        value_Dropdown = GameObject.Find("levelChoice").GetComponent<Dropdown>();
        Level = value_Dropdown.value.ToString();
        Debug.Log(Level);
        saveValue.level = Level;
    }

    public void getLanguage(){
        value_Dropdown = GameObject.Find("languageChoice").GetComponent<Dropdown>();
        Language = value_Dropdown.value.ToString();
        Debug.Log(Language);
        saveValue.language = Language;
    }

}
