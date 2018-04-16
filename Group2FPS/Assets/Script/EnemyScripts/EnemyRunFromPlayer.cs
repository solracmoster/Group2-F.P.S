using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyRunFromPlayer : MonoBehaviour {
    NavMeshAgent agent;
    public GameObject player;
    private float distance;
    public float triggerDistance = 100;
    // Use this for initialization
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = (gameObject.transform.position - player.transform.position).magnitude;
        if(distance <= triggerDistance)
        {
            agent.destination = gameObject.transform.position - player.transform.position;
        }
    }
}
