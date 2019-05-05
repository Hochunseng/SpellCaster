using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    private ParticleSystem.EmissionModule ps;
    void Start()
    {
        GetComponentInChildren<ParticleSystem>().Stop();
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            GetComponentInChildren<ParticleSystem>().Play();

        }
        else
        {
            GetComponentInChildren<ParticleSystem>().Stop();
        }
    }
}
