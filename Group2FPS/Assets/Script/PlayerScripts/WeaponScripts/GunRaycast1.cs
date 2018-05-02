
using UnityEngine;

public class GunRaycast1 : MonoBehaviour {
   // public float damage = 10;
   // public float range = 100;
   public float shotCooldown = .1f;
    public Camera FPSCam;
    public ParticleSystem muzzelFlash;
    private AudioSource gunSound;
    private float timer;
    private bool onCooldown = false, isShooting = false;
    public int ammo = 150;

    private void Start()
    {
        gunSound = FPSCam.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButton(2) && onCooldown == false && ammo > 0)
        {
            onCooldown = true;
            muzzelFlash.Play();
            Shoot();

        }
        if (Input.GetMouseButtonUp(2) || ammo <= 0)
        {
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
    }
    void Shoot()
   {
        ammo -= 1;
        gunSound.Play();
      //  RaycastHit hitInfo;
      //  if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hitInfo, range))
      //  {
      //      Debug.Log(hitInfo.transform.name);
       //     EnemyTakeDamage target = hitInfo.transform.GetComponent<EnemyTakeDamage>();
       //     if (target != null)
       //     {
        //        target.TakeDamage(damage);
        //    }
        //    if(hitInfo.transform.name == "WeakPoint")
        //    {
         //       hitInfo.transform.GetComponent<DragonWeakPoint>().TakeDamage(damage);
         //   }
      //      if(hitInfo.transform.tag == "Bird")
         //   {
              //  hitInfo.transform.GetComponent<Bird>().TakeDamage(damage);
          //  }
    }
       
    }

