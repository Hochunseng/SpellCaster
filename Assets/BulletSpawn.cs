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
        if(Input.GetKey("a"))
        {
            GameObject bull = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            bull.GetComponent<Rigidbody>().AddForce(transform.position * 1000);
        }
    }
}
