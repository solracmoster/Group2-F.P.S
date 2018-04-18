using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displaymytext1 : MonoBehaviour {

	// Use this for initialization
	float timeLeft;
	void Start () {
        timeLeft += Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft += Time.deltaTime;
        GetComponent<Text> ().text = "" + timeLeft;
	}
}
