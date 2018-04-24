using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigRotation : MonoBehaviour {
    public GameObject player;
    private Vector3 lookDirection;
    private Quaternion lookRot;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lookDirection = player.transform.position - transform.position;
        lookRot = Quaternion.LookRotation(lookDirection);
        gameObject.transform.rotation = lookRot;
    }
}
