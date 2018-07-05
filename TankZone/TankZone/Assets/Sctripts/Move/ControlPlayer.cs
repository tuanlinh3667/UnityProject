using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour {
    float currentMoveSpeed = 0;
    float finalMoveSpeed = 0;   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentMoveSpeed = Mathf.MoveTowards(currentMoveSpeed, finalMoveSpeed, Time.deltaTime);
        //Debug.Log("currentMoveSpeed: " + currentMoveSpeed);
        transform.Translate(new Vector3(0, 0, 1 * currentMoveSpeed * Time.deltaTime));


        //di chuyen tien len, lui lai
        if (Input.GetKey(KeyCode.W))
        {
            finalMoveSpeed = 5;
            Audio.Instance.PlayMusicGame(0);
            
        }

        if (Input.GetKeyUp(KeyCode.W) || 
            Input.GetKeyUp(KeyCode.S) || 
            Input.GetKeyUp(KeyCode.A) || 
            Input.GetKeyUp(KeyCode.D))
        {
            finalMoveSpeed = 0;
            Audio.Instance.aS.Stop();
        }

        if (Input.GetKey(KeyCode.S))
        {
            finalMoveSpeed = -5;
            Audio.Instance.PlayMusicGame(0);
        }

        // di chuyen sang trai, phai
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 20 * Time.deltaTime, 0));
            Audio.Instance.PlayMusicGame(0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -20 * Time.deltaTime, 0));
            Audio.Instance.PlayMusicGame(0);
        }


    }
}
