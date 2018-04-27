using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    GameObject prefab;
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 20;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Soundmanagerscript.PlaySound("Whiff1");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Soundmanagerscript.PlaySound("Whiff2");
        }
        if (Input.GetKeyDown("space"))
        {
            Soundmanagerscript.PlaySound("Hop");
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Soundmanagerscript.PlaySound("Halt");
        }
        if (Input.GetKeyDown("w"))
        {
            Soundmanagerscript.PlaySound("Run");
        }
    }
}