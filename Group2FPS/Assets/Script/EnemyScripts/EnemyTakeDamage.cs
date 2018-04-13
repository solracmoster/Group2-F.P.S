using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour {
    public float health = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Die();
        }
	}

    public void TakeDamage(float damageTaken)
    {
        health = health - damageTaken;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
