using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleShooting : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletforce = 20f;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();
        bulletrb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }
    
}
