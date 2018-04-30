using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Trackdead : MonoBehaviour {

	// Use this for initialization
	int Tracker1;
	void Start () {
		Tracker1 = PlayerPrefs.GetInt ("Tracker1");
	}
	
	// Update is called once per frame
	void Update () {
		

        if (PlayerPrefs.GetInt("Tracker1") <= 1)
        {
            Destroy(this.gameObject);


        }
    }
}
