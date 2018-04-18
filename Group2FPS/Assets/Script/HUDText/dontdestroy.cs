using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroy : MonoBehaviour {


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//when we load the actual game we need to kil this object
		//if (SceneManager.GetActiveScene ().name == "Title") {
			//Destroy (this.gameObject);
	}
}
