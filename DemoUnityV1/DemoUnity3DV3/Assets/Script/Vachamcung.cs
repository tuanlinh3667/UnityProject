using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamcung : MonoBehaviour {
    
    // Use this for initialization
    void Start()
    {
        Debug.Log("This is start!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is update");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Start collide");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Being collide");
        Rigidbody rigi = GetComponent<Rigidbody>();
        rigi.AddForce(transform.up * 250);
        rigi.useGravity = true;
        Destroy(collision.gameObject, 0.8f);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit collide");
    }
}   
