using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee1 : MonoBehaviour
{

    GameObject prefab;
    void Start()
    {
        prefab = Resources.Load("bullet") as GameObject;
    }

    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            GameObject bullet = Instantiate(prefab) as GameObject;
            bullet.transform.position = transform.position + Camera.main.transform.forward * 5;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 80;
        }

       // if (Input.GetMouseButtonDown(2))
       // {
       //     Soundmanagerscript.PlaySound("Whiff1");
       // }
       
    }
}