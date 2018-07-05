using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTrigger(bool trigger)
    {
        trigger = true;
    }

    public void ConnectPlayer(string playerName)
    {
        if (playerName == "Player_1")
        {
            var _id_1 = Controller.listPlayer.Single(tank => tank.playerName == "Player_1");
            _id_1.playerStatus = true;

            var _id_2 = Controller.listPlayer.Single(tank => tank.playerName == "Player_2");
            _id_2.playerStatus = false;
            Debug.Log("vao Player 1");
        }

        if (playerName == "Player_2")
        {
            var _id_1 = Controller.listPlayer.Single(tank => tank.playerName == "Player_1");
            _id_1.playerStatus = false;

            var _id_2 = Controller.listPlayer.Single(tank => tank.playerName == "Player_2");
            _id_2.playerStatus = true;

            Debug.Log("Vao player 2");
        }
    }
}
