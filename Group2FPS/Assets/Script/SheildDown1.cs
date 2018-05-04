using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SheildDown1: MonoBehaviour {

	// Use this for initialization
	int coin;
	void Start () {
		coin = PlayerPrefs.GetInt ("Coin");
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Coin") >= 200)
        {
            Destroy(this.gameObject);

        }
    }
}
