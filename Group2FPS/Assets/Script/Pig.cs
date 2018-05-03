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
    private bool on = true;
    public GameObject effect;
    // Use this for initialization
    void Start () {
        anim = GetComponentInChildren<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        lookDirection = player.transform.position - transform.position;
        lookDirection.y = 0;
        lookRot = Quaternion.LookRotation(lookDirection);
        lookRot *= Quaternion.Euler(0, 270, 0);
        distance = (player.transform.position - gameObject.transform.position).magnitude;
        if (distance <= triggerDistance && on == true)
        {
            RunAway();

        }
        if(distance > triggerDistance && on == true)
        {
            idle();
        }
        if(on == false)
        {
            idle();
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
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
        gameObject.transform.rotation = transform.rotation;
    }
    public void InPen()
    {
        if(on == true)
        {
            on = false;
            Instantiate(effect, gameObject.transform.position, effect.transform.rotation);
            Debug.Log("InPen");
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 5);
            Soundmanagerscript.PlaySound("Coin");
        }
    }
}
