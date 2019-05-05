using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collided");
        if (collision.gameObject.name != "Enemy")
        {
            print("Collided with wall");
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
