﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class END1: MonoBehaviour {

    // Use this for initialization
    public int health = 1;
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //reload the scene
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Story2");



        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player") {
            health--;
            // Soundmanagerscript.PlaySound("PHurt");
        }

		
    }
   
}