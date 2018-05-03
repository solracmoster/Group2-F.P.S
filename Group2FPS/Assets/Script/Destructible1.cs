
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible1 : MonoBehaviour
{

    public GameObject destroyedVersion; // Reference to the shattered version of the object

    // If the player clicks on the object
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fist" || collision.gameObject.tag == "bullet")
        {
            Soundmanagerscript.PlaySound("Glass");
            // Spawn a shattered object
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            // Remove the current object
            Destroy(gameObject);
        }

    }
}
