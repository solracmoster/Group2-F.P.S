﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Coinage : MonoBehaviour {

	// Use this for initialization
	
    public int coin = 0;

    void Start () {
        //DontDestroyOnLoad(this.gameObject);
        PlayerPrefs.SetInt("Coin", coin);
    }
    

    // Update is called once per frame
    void Update()
    {
          
    }
    

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Coin"))
        {
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
            //Soundmanagerscript.PlaySound("Coin");
            Debug.Log("Coin");
        }

       
    }

}