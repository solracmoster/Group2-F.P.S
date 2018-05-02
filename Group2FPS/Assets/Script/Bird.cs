using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    private bool changeDirection = false;
    public float moveSpeed = 10, maxDistance = 10;
    private Quaternion rot;
    private Vector3 startPos, endPos;
    private float distance = 0;
    public float health = 1;
    public GameObject deathEffect;
	// Use this for initialization
	void Start () {
        startPos = gameObject.transform.position;
        rot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        if(health <= 0)
        {
            Dead();
        }
        if(changeDirection == false)
        {
            transform.position += transform.forward * -moveSpeed;
            distance = (transform.position - startPos).magnitude;
            rot.y = 0;
            gameObject.transform.rotation = rot;
            if (distance >= maxDistance)
            {
                distance = 0;
                startPos = gameObject.transform.position;
                changeDirection = true;
            }
        }
        if(changeDirection == true)
        {
            transform.position += transform.forward * -moveSpeed;
            distance = (transform.position - startPos).magnitude;
            rot.y = 180;
            gameObject.transform.rotation = rot;
            if (distance >= maxDistance)
            {
                distance = 0;
                startPos = gameObject.transform.position;
                changeDirection = false;
            }
        }


	}
    public void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
        Debug.Log("bird HP " + health);
    }
    private void Dead()
    {
        Instantiate(deathEffect, gameObject.transform.position, transform.rotation);
        Debug.Log("kill bird mission complete");
        Destroy(gameObject);
    }
}
