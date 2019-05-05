using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    private ParticleSystem.EmissionModule ps;
    public GameObject bullet;
    //public AudioSource source;
    public AudioClip water;

    void Start()
    {
        //source = GetComponent<AudioSource>();
        GetComponentInChildren<ParticleSystem>().Stop();
    }

    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            //source.PlayOneShot(water, 0.5f);
            GetComponent<AudioSource>().Play();

            print("spawned");
            GetComponentInChildren<ParticleSystem>().Play();
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            
        }
        else
        {
            GetComponent<AudioSource>().Stop();
            GetComponentInChildren<ParticleSystem>().Stop();
        }
    }
}
