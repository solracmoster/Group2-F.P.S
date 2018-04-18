using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displaymytext3 : MonoBehaviour {

	// Use this for initialization
	int money;
	void Start () {
		money = PlayerPrefs.GetInt ("Money");
	}
	
	// Update is called once per frame
	void Update () {
		money = PlayerPrefs.GetInt ("Money");
		GetComponent<Text> ().text = "" + money;
	}
}
