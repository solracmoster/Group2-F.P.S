using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class P2 : MonoBehaviour {

	//public int health = 1;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		

		}



    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
            //when the player runs into an enemy reduce the players health
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Testz");
            //health--;

        }
	}
}