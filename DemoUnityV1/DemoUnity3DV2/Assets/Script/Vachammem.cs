using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachammem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("This is start!");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("This is update");
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("This is start collide!");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("This is be colliding!");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit collide!");
    }
}
