using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveCurrentScene : MonoBehaviour {
    public int myScene;
    int sceneToLoad;
	// Use this for initialization
	void Start () {
        myScene = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
	}
    public void SaveScene()
    {
        PlayerPrefs.SetInt("savedScene", myScene);
    }
    public void LoadSavedScene()
    {
        sceneToLoad = PlayerPrefs.GetInt("savedString");
        SceneManager.LoadScene(sceneToLoad);
    }
}
