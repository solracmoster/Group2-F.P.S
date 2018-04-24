using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {
    public GameObject flamePrefab, player, firePoint;
    public float distanceToActivate = 100, attackCooldown = 10;
    private Vector3 playerPos, lookDirection;
    private float distance, attackTimer = 0;
    private Quaternion lookRot;
    private bool canAttack = false, canRotate = false;
    private float attackDuration;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        playerPos = player.transform.position;
        lookDirection = playerPos - transform.position;
        distance = (transform.position - playerPos).magnitude;
        lookRot = Quaternion.LookRotation(lookDirection);
        lookRot *= Quaternion.Euler(0, 90, 0);

        if(distance <= distanceToActivate)
        {
           if(canAttack == false)
            {
                attackTimer += Time.deltaTime;
                //rotate dragon head if the he is done attacking but not ready to start next attack
                if (attackTimer >= attackDuration)
                {
                    anim.SetBool("isOpen", false);
                    if(canRotate == true)
                    {
                        gameObject.transform.rotation = lookRot;
                    }
                }
            }
           
           if(attackTimer >= attackCooldown || canAttack == true) 
            {
                anim.SetBool("isOpen", true);
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
            Quaternion flameRot = Quaternion.LookRotation(lookDirection);
            GameObject FlameShot = Instantiate(flamePrefab, firePoint.transform.position, flameRot);
            FlameShot.GetComponent<DragonFlame>().FindDragon(gameObject);
        }
    }
    public void GetAttackDuration(float dur)
    {
        attackDuration = dur;
    }
    public void PlayerInZone(bool inZone)
    {
        canRotate = inZone;
    }

}
