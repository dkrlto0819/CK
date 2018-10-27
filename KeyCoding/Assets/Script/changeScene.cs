using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GotoSecond(){
        SceneManager.LoadScene("SecondScene");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
