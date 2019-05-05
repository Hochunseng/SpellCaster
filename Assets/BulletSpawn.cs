using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        //if (Input.GetKeyDown("a"))
        {
            print("spawned");
            GameObject bull = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            bull.GetComponent<Rigidbody>().AddForce(transform.forward * 3000);

            OVRInput.SetControllerVibration(10, 10, OVRInput.Controller.RTouch);
        }
        else
        {
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
        }
    }
}
