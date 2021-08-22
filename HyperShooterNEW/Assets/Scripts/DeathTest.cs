using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTest : MonoBehaviour
{
    public int health = 100;
    public GameObject deathexplosioneffect;
    public void takedamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathexplosioneffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
