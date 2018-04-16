using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displaymytext2 : MonoBehaviour {

	// Use this for initialization
	int coin;
	void Start () {
		coin = PlayerPrefs.GetInt ("Coins");
	}
	
	// Update is called once per frame
	void Update () {
		coin = PlayerPrefs.GetInt ("Coins");
		GetComponent<Text> ().text = "" + coin;
	}
}
