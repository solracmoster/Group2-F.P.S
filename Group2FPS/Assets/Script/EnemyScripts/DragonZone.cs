using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonZone : MonoBehaviour {
    public GameObject dragon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dragon.GetComponent<Dragon>().PlayerInZone(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        dragon.GetComponent<Dragon>().PlayerInZone(false);
    }
}
