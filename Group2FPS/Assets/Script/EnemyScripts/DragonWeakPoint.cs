using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWeakPoint : MonoBehaviour {
    public float health = 1000;
    public bool open = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            gameObject.GetComponentInParent<Dragon>().Ded();
        }
	}
    public void TakeDamage(float damage)
    {
        if(open == true)
        {
            health -= damage;
        }
        Debug.Log("dragonHP " + health);
    }
    public void Open(bool isOpen)
    {
        open = isOpen;
        Debug.Log("open " + open);
    }
    
}
