using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject tank;
    public GameObject turret;
    Transform followPoint;
	// Use this for initialization
	void Start () {
        followPoint = new GameObject().transform;
        followPoint.name = "Follow Point";
        followPoint.position = transform.position;
        followPoint.SetParent(turret.transform);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Slerp(transform.position, followPoint.position, 2 * Time.deltaTime);
        transform.eulerAngles = new Vector3(
            Mathf.LerpAngle(transform.eulerAngles.x, followPoint.transform.eulerAngles.x + 3, 20 * Time.deltaTime),
            Mathf.LerpAngle(transform.eulerAngles.y, followPoint.transform.eulerAngles.y, 20 * Time.deltaTime),
            transform.eulerAngles.z
            );
    }
}
