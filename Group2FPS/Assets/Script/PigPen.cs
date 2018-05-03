using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigPen : MonoBehaviour {
    public int totalPigs = 5;
    private int pigsInPen = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pig")
        {
            pigsInPen += 1;
           other.gameObject.GetComponent<Pig>().InPen();
            if(pigsInPen >= totalPigs)
            {
                Debug.Log("pig mission Complete");
            }
        }
    }
}
