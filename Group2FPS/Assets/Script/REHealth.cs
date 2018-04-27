using UnityEngine;
using System.Collections;

public class REHealth : MonoBehaviour {

	public int health = 3;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(health <= 0) {
           Soundmanagerscript.PlaySound("Hit");
            Destroy(this.gameObject);

        }

		}



	void OnCollisionEnter(Collision collision){
        // force is how forcefully we will push the player away from the enemy.
        //float force = 3;

        if (collision.gameObject.tag == "Fist"){
			//when the player runs into an enemy reduce the players health
			health--;
            Soundmanagerscript.PlaySound("Hit");

            // Calculate Angle Between the collision point and the player
           // Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
           // dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
           // GetComponent<Rigidbody>().AddForce(dir * force);


        }
    }
}