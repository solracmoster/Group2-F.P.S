using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown (KeyCode.Escape)) {
            Time.timeScale = 0;
            gameObject.GetComponent<Canvas>().enabled = true;
        }

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }
    }


    public void Resume(){
        Time.timeScale = 1;
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    public void Exit(){
        Application.Quit();
    }

}
