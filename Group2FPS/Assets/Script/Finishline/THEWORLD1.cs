using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEWORLD1 : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            GameObject.Find("P1").SendMessage("Finnish");
    }
}
