
using UnityEngine;

public class GunRaycast : MonoBehaviour {
    public float damage = 10;
    public float range = 100;
    public float shotCooldown = .1f;
    public Camera FPSCam;
    public ParticleSystem muzzelFlash;
    private float timer;
    private bool onCooldown = false;
    void Update()
    {
        if (Input.GetAxis("Fire1") != 0 && onCooldown == false)
        {
            Shoot();
            muzzelFlash.Play();
        }
        if (onCooldown == true)
        {
            timer += Time.deltaTime;
            muzzelFlash.Stop();
            if(timer >= shotCooldown)
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
