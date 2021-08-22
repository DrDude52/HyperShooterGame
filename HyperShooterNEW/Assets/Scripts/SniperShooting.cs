using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperShooting : MonoBehaviour
{
    public Transform firepoint;
    public ParticleSystem sniperexplosioneffect;
    public LineRenderer line;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
    }
    IEnumerator Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(firepoint.position, firepoint.up);
        if (hit)
        {
            Debug.Log(hit.transform.name);
            Instantiate(sniperexplosioneffect, hit.point, Quaternion.identity);

            line.SetPosition(0, firepoint.position);
            line.SetPosition(1, hit.point);
        } else
        {
            line.SetPosition(0, firepoint.position);
            line.SetPosition(1, firepoint.position + firepoint.up * 100);
        }
        line.enabled = true;
        yield return new WaitForSeconds(0.02f);
        line.enabled = false;
    }
}
