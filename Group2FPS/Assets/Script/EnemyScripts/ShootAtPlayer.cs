using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ShootAtPlayer : MonoBehaviour {

    NavMeshAgent agent;
    public GameObject player;
    public float triggerDistance = 100, shotSpeed = 1, shootDelay = 3;
    private float distance, myHP, originalHP, timer = 0;
    public GameObject shotPrefab, firePoint;
    private Vector3 lookDirection;
    private bool onCooldown = false;
    private Quaternion lookRot;
    // Use this for initialization
    void Start()
    {
        originalHP = gameObject.GetComponent<EnemyTakeDamage>().health;
        myHP = originalHP;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = player.transform.position - gameObject.transform.position;
        lookRot = Quaternion.LookRotation(lookDirection);
        distance = (gameObject.transform.position - player.transform.position).magnitude;
        if (distance <= triggerDistance)
        {
            if (myHP >= (originalHP * 0.5f) && distance > triggerDistance * 0.2f)
            {
                Chase();
            }
            if (myHP >= (originalHP * 0.5f) && distance <= triggerDistance * 0.2f)
            {
                Attack();
            }
            if (myHP < (originalHP * 0.5f))
            {
                Run();
            }
        }
        if(onCooldown == true)
        {
            timer += Time.deltaTime;
            if(timer >= shootDelay)
            {
                timer = 0;
                onCooldown = false;
            }
        }

    }
    public void SetHP(float health)
    {
        myHP = health;
    }

    public void Run()
    {
        agent.destination = gameObject.transform.position - player.transform.position;
    }
    public void Chase()
    {
        agent.destination = player.transform.position;
    }
    public void Attack()
    {
        agent.destination = gameObject.transform.position;
        gameObject.transform.rotation = lookRot;
        //shoot at player
        if(onCooldown == false)
        {
            GameObject shot = Instantiate(shotPrefab, firePoint.transform.position,firePoint.transform.rotation);
            shot.GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;
            onCooldown = true;
        }

    }
}
