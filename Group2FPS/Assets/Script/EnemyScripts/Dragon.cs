using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {
    public GameObject flamePrefab, player, firePoint;
    public float distanceToActivate = 100, attackCooldown = 10;
    private Vector3 playerPos, lookDirection;
    private float distance, attackTimer = 100;
    private Quaternion lookRot;
    private bool canAttack = true, canRotate = false;
    private float attackDuration, attackprepTimer = 10;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        playerPos = player.transform.position;
        distance = (transform.position - playerPos).magnitude;

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
                        lookDirection = playerPos - transform.position;
                        lookRot = Quaternion.LookRotation(lookDirection);
                        lookRot *= Quaternion.Euler(0, 90, 0);
                        gameObject.transform.rotation = lookRot;
                    }
                }
            }
           
           if(attackTimer >= attackCooldown || canAttack == true) 
            {
                anim.SetBool("isOpen", true);
                canAttack = true;
                attackTimer = 0;
                attackprepTimer += Time.deltaTime;
                if(attackprepTimer > .5f)
                {
                    Attack(1);
                    attackprepTimer = 0;
                    canAttack = false;
                }
                
            }

        }

	}

    public void Attack(int attackNum)
    {
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
