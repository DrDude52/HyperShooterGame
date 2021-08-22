using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffectDestruction : MonoBehaviour
{
  
    void Update()
    {
        Destroy(gameObject, 1f);
    }
}
