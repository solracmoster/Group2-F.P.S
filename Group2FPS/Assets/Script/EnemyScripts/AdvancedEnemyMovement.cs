using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AdvancedEnemyMovement : MonoBehaviour {
    NavMeshAgent agent;
    public GameObject player;
    public float triggerDistance = 100;
    private float distance, myHP, originalHP;
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
        distance = (gameObject.transform.position - player.transform.position).magnitude;
        if (distance <= triggerDistance)
        {
            if(myHP >= (originalHP * 0.5f) && distance > triggerDistance * 0.2f)
            {
                Chase();
            }
            if(myHP >= (originalHP * 0.5f) && distance <= triggerDistance * 0.2f)
            {
                Attack();
            }
            if(myHP < (originalHP * 0.5f))
            {
                Run();
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
        //this needs to be finished once we know what attack our enemy does
        agent.destination = gameObject.transform.position;
    }
}
