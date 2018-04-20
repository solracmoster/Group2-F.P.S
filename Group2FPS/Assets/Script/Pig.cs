using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Pig : MonoBehaviour {
    Animator anim;
    NavMeshAgent agent;
    public GameObject player;
    private float distance;
    public float triggerDistance = 10;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        distance = (gameObject.transform.position - player.transform.position).magnitude;
        if (distance <= triggerDistance)
        {
            RunAway();

        }
        if(distance > triggerDistance)
        {
            idle();
        }
    }
    private void RunAway()
    {
        agent.destination = gameObject.transform.position - player.transform.position;
        anim.SetBool("isWalking", true);
    }
    private void idle()
    {
        agent.destination = agent.destination = gameObject.transform.position;
        anim.SetBool("isWalking", false);
    }
}
