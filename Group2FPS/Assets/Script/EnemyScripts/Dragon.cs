using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {
    public GameObject flamePrefab, player, firePoint;
    public float distanceToActivate = 100, attackCooldown = 10;
    private Vector3 playerPos, lookDirection;
    private float distance, attackTimer = 0;
    private Quaternion lookRot;
    private bool canAttack = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerPos = player.transform.position;
        lookDirection = playerPos - transform.position;
        distance = (transform.position - playerPos).magnitude;
        lookRot = Quaternion.LookRotation(lookDirection);

        if(distance <= distanceToActivate)
        {
           if(canAttack == false)
            {
                gameObject.transform.rotation = lookRot;
                attackTimer += Time.deltaTime;
            }
           
           if(attackTimer >= attackCooldown || canAttack == true) 
            {
                canAttack = true;
                attackTimer = 0;
                Attack(1);
            }

        }

	}

    public void Attack(int attackNum)
    {
        canAttack = false;
        //shoot flame forward
        if (attackNum == 1)
        {
            Quaternion flameRot = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            GameObject FlameShot = Instantiate(flamePrefab, firePoint.transform.position, firePoint.transform.rotation);
        }
    }
  
}
