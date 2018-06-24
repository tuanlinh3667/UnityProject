using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamcung : MonoBehaviour {
    public GameObject obj;
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

    void OnCollisionEnter(Collision collide)
    {
        Debug.Log("This is start collide!");
    }

    void OnCollisionStay(Collision collide)
    {
        if (collide.gameObject.name == "Matphang2")
        {
            obj = GameObject.Find("Matphang2");
            Destroy(obj);
        }
        else
        {
            obj = GameObject.Find("Matphang4");
            Destroy(obj, 3f);
        }
        
    }

    void OnCollisionExit(Collision collide)
    {
        Debug.Log("Exit collide!");
    }
}
