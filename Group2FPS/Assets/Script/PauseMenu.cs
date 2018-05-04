using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            gameObject.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            Time.timeScale = 1;

            gameObject.GetComponent<Canvas>().enabled = false;
        }



    }

	

	public void Resume(){
		Time.timeScale = 1;
		gameObject.GetComponent<Canvas> ().enabled = false;
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void LoadMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
