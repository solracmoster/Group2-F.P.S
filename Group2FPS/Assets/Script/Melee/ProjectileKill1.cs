using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKill1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, 1.0f);
    }
}
