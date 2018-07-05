using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Controller : MonoBehaviour {
    public GameObject player_1;
    public GameObject player_2;
    public bool sPlay;
    public float speed = 5;
    public bool sP1;
    public bool sP2;


    public static List<ListPlayer> listPlayer;
	// Use this for initialization
	void Start () {
        listPlayer = new List<ListPlayer>();

        ListPlayer newObj;
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Player"))
        {
            Debug.Log(obj.transform.name);
            newObj = new ListPlayer();
            newObj.id = null;
            newObj.playerName = obj.transform.name;
            newObj.playerColor = obj.GetComponent<MeshRenderer>().material.color.ToString();
            listPlayer.Add(newObj);
        }

        foreach ( var item in listPlayer)
        {
            Debug.Log(item.id + "**" + item.playerName + "***" + item.playerColor + "****" + item.playerStatus);
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (!sPlay)
        {
            player_1.transform.Translate(new Vector3(
                speed * Input.GetAxis("Horizontal") * Time.deltaTime,
                0,
                speed * Input.GetAxis("Vertical") * Time.deltaTime));
            if (sP1 == false)
            {
                player_1.SendMessage("ConnectPlayer", "Player_1");
                sP1 = true;
                sP2 = false;
            }
            
        }
        else
        {
            player_2.transform.Translate(new Vector3(
                speed * Input.GetAxis("Horizontal") * Time.deltaTime, 
                0, 
                speed * Input.GetAxis("Vertical") * Time.deltaTime));
            if (sP2 == false)
            {
                player_2.SendMessage("ConnectPlayer", "Player_2");
                sP1 = false;
                sP2 = true;
            }
        }
	}
}
