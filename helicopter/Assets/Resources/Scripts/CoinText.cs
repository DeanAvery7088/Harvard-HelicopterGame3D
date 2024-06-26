﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class CoinText : MonoBehaviour {

	public GameObject helicopter;
	private Text text;
	private int coins;
	private int gems;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (helicopter != null) {
			coins = helicopter.GetComponent<HeliController>().coinTotal;
			gems = helicopter.GetComponent<HeliController>().gemTotal;				
		}

		text.text = "Scrolling Speed: " + SkyscraperSpawner.speed + "\nCoins: " + coins;
		//text.text = "Scrolling Speed: " + SkyscraperSpawner.speed + "\nCoins: " + coins + "\nGems: " + gems;

	}
}
