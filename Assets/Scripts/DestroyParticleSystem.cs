﻿using UnityEngine;
using System.Collections;

public class DestroyParticleSystem : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {

        if(ps)
        {
            if(!ps.IsAlive())
            {
                Destroy(gameObject);
            }
        }
    }
}
