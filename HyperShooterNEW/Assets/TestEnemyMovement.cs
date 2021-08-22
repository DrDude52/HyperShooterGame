using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyMovement : MonoBehaviour
{

    public float speed = 20f;
    public Transform enemypos;
    public Transform player;

    void FixedUpdate()
    {
        enemypos.Translate(Vector2.up * speed * Time.deltaTime);
        enemypos.LookAt(player);
    }
}
