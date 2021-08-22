using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShooting : MonoBehaviour
{
    public Transform firepointside1;
    public Transform firepointside12;
    public Transform firepointmiddle;
    public Transform firepointside2;
    public Transform firepointside22;
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
        GameObject bullet12 = Instantiate(bulletPrefab, firepointside12.position, firepointside12.rotation);
        Rigidbody2D bulletrb12 = bullet12.GetComponent<Rigidbody2D>();
        bulletrb12.AddForce(firepointside12.up * bulletforce, ForceMode2D.Impulse);
        GameObject bullet1 = Instantiate(bulletPrefab, firepointside1.position, firepointside1.rotation);
        Rigidbody2D bulletrb = bullet1.GetComponent<Rigidbody2D>();
        bulletrb.AddForce(firepointside1.up * bulletforce, ForceMode2D.Impulse);
        GameObject bullet2 = Instantiate(bulletPrefab, firepointmiddle.position, firepointmiddle.rotation);
        Rigidbody2D bulletrb2 = bullet2.GetComponent<Rigidbody2D>();
        bulletrb2.AddForce(firepointmiddle.up * bulletforce, ForceMode2D.Impulse);
        GameObject bullet3 = Instantiate(bulletPrefab, firepointside2.position, firepointside2.rotation);
        Rigidbody2D bulletrb3 = bullet3.GetComponent<Rigidbody2D>();
        bulletrb3.AddForce(firepointside2.up * bulletforce, ForceMode2D.Impulse);
        GameObject bullet22 = Instantiate(bulletPrefab, firepointside22.position, firepointside22.rotation);
        Rigidbody2D bulletrb22 = bullet22.GetComponent<Rigidbody2D>();
        bulletrb22.AddForce(firepointside22.up * bulletforce, ForceMode2D.Impulse);
    }

}
