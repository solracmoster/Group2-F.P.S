﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Animation>().Play("LPunch");
        }
    }
}
