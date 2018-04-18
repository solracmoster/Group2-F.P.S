using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFlame : MonoBehaviour {
    private float timer = 0;
    public float duration = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= duration)
        {
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerStats>().SetFire(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerStats>().SetFire(false);
        }
    }
}
