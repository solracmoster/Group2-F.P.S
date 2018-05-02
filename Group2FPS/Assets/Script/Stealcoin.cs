using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stealcoin : MonoBehaviour {

    int coin;
	void Start () {
		coin = PlayerPrefs.GetInt ("Coin");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
           
            Soundmanagerscript.PlaySound("Coin");
        }

    }
}
