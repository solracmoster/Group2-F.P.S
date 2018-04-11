using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiAutoGun : MonoBehaviour {

    public float damage = 10;
    public float range = 100;
    public float shotCooldown = .1f;
    public Camera FPSCam;
    public ParticleSystem muzzelFlash;
    private float timer;
    private bool onCooldown = false;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && onCooldown == false)
        {
            muzzelFlash.Play();
            Shoot();
        }
       
        if (onCooldown == true)
        {
            timer += Time.deltaTime;
            if (timer >= shotCooldown)
            {
                onCooldown = false;
                timer = 0;
            }
        }
    }
    void Shoot()
    {

        RaycastHit hitInfo;
        if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.name);
            EnemyTakeDamage target = hitInfo.transform.GetComponent<EnemyTakeDamage>();
            if (target != null)
            {
                target.TakeDamage(damage);
                onCooldown = true;
            }
        }
    }
}
