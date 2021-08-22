using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BortMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D BortRB;
    public Camera playercamera;
    Vector2 mousePosition;
    Vector2 movement; 
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePosition = playercamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        BortRB.MovePosition(BortRB.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePosition - BortRB.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        BortRB.rotation = angle;
    }
}
