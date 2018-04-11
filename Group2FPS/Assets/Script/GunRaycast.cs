
using UnityEngine;

public class GunRaycast : MonoBehaviour {
    public float damage = 10;
    public float range = 100;
    public float shotCooldown = .1f;
    public Camera FPSCam;
    public ParticleSystem muzzelFlash;
    private float timer;
    private bool onCooldown = false, isShooting = false;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && onCooldown == false)
        {
            isShooting = true;
            muzzelFlash.Play();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            isShooting = false;
            muzzelFlash.Stop();
        }
        if (onCooldown == true)
        {
            timer += Time.deltaTime;
            if(timer >= shotCooldown)
            {
                onCooldown = false;
                timer = 0;
            }
        }
        if(isShooting == true)
        {
            Shoot();
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
