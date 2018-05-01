using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {
    private bool dragonDead = false;
    private float timer = 0;
    public string endScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dragonDead == true)
        {
            timer += Time.deltaTime;
            if(timer > 5)
            {
                Debug.Log("Load end Scene");
                SceneManager.LoadScene(endScene);
            }
        }
	}
    public void DragonDead()
    {
        dragonDead = true;
    }
}
