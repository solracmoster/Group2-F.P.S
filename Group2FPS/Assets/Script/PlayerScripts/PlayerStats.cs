using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    public int maxHealth = 100;
    private int health;
    private bool inFire = false, onFire = false;
    private float fireTimer = 0, fireDamageTimer = 0;
    public ParticleSystem fireEffect;
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
        if(onFire == true)
        {
            fireDamageTimer += Time.deltaTime;
            if(fireDamageTimer >= 1)
            {
                if(inFire == true)
                {
                    TakeDamage(4);
                }
                if(inFire == false)
                {
                    TakeDamage(2);
                }
                fireDamageTimer = 0;
            }
            if(inFire == false)
            {
                fireTimer += Time.deltaTime;
                if(fireTimer >= 5)
                {
                    onFire = false;
                    fireEffect.Stop();
                    fireTimer = 0;
                }
            }
        }
	}

    public void TakeDamage(int damage)
    {
        health = health - damage;
        Debug.Log("Health" + health);
    }
    public void SetFire(bool inFlame)
    {
        inFire = inFlame;
        if(inFire == true)
        {
            fireTimer = 0;
            fireEffect.Play();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "setFire")
        {
            SetFire(false);
        }
    }
}
