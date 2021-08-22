using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    public int damage = 40;
    public ParticleSystem bulletexplosion;
    void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log(hit.name);
        Destroy(gameObject);
    }
    void Start()
    {
        StartCoroutine(SelfDestructBullet());
    }


    IEnumerator SelfDestructBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        DeathTest deathTest = collision.gameObject.GetComponent<DeathTest>();
        if (deathTest != null)
        {
            deathTest.takedamage(damage);
        }
        ParticleSystem effect = Instantiate(bulletexplosion, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }

}
