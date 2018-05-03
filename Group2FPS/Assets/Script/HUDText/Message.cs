using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour {
    public GameObject textObj;
    public string message;
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
            //show message
            textObj.GetComponent<Text>().enabled = true;
            textObj.GetComponent<Text>().text = message;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //hide message
            textObj.GetComponent<Text>().enabled = false;
        }
    }
}
