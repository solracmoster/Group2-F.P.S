﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnButtonClick(){
		SceneManager.LoadScene ("Story1");
	}
}
