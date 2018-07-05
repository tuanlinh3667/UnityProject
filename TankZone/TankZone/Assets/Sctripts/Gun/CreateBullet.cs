using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour {
    public GameObject bullet;
    public Transform positionBullet;
    Rigidbody rigi;


   public float fogre =100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newobj;
            newobj = Instantiate(bullet, positionBullet.position, Quaternion.identity) as GameObject;
            newobj.transform.Rotate(90,0,0);
            Audio.Instance.PlayMusicGame(1);
            rigi = newobj.GetComponent<Rigidbody>();
            rigi.AddForce(positionBullet.transform.right * fogre,ForceMode.Acceleration);
        }
    }
}
