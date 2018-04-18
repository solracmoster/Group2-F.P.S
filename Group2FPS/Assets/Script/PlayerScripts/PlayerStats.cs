using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    public int maxHealth = 100;
    private int health;
    private bool inFire = false, onFire = false;
    private float fireTimer = 0, fireDamageTimer = 0;
	// Use this for initialization
	void Start () {
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(inFire == true)
        {
            onFire = true;
        }
        if(onFire == true && fireDamageTimer >= 1)
        {
            
        }
	}

    public void TakeDamage(int damage)
    {
        health = health - damage;
        Debug.Log(health);
    }
    public void SetFire(bool inFlame)
    {
        inFire = true;
    }
}
