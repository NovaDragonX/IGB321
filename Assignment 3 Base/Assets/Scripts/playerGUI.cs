﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerGUI : MonoBehaviour {

    GameObject player;

    public Slider healthbar;
    public GameObject levelCompleteText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!player) {
            player = GameObject.FindGameObjectWithTag("Player");
            healthbar.value = 0;
        }
        else if (player) {
            healthbar.value = player.GetComponent<Player>().health;
        }


        //Level Status Text
        if (GameManager.instance.levelComplete)
            levelCompleteText.SetActive(true);

	}
}
