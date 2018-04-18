﻿using UnityEngine;
using System.Collections;


public class EnemyH : MonoBehaviour {

	public int health = 3;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(health <= 0) {
            //Soundmanagerscript.PlaySound("EDie");
            Destroy(this.gameObject);

        }

		}



	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Fist"){
			//when the player runs into an enemy reduce the players health
			health--;
            
            //Soundmanagerscript.PlaySound("EHurt");

        }
	}
}