using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectObject : MonoBehaviour
{
    public float lifetime = 1f;
    
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,lifetime);
    }
}
