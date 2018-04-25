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
    private Vector3 lookDirection;
    private Quaternion lookRot;
    // Use this for initialization
    void Start () {
        anim = GetComponentInChildren<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        lookDirection = player.transform.position - transform.position;
        lookRot = Quaternion.LookRotation(lookDirection);
        lookRot *= Quaternion.Euler(0, 270, 0);
        distance = (gameObject.transform.position - player.transform.position).magnitude;
        if (distance <= triggerDistance)
        {
            RunAway();
            //gameObject.transform.rotation = new Quaternion(lookRot.x, (lookRot.y + 90) * -1, lookRot.z, lookRot.w);

        }
        if(distance > triggerDistance)
        {
            idle();
        }
    }
    private void RunAway()
    {
        agent.destination = gameObject.transform.position - player.transform.position;
        gameObject.transform.rotation = lookRot;      
        anim.SetBool("isWalking", true);
    }
    private void idle()
    {
        agent.destination = agent.destination = gameObject.transform.position;
        anim.SetBool("isWalking", false);
    }
}
