﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour {

	public Text countText;
	public Text winText;

	private int count;

	//current scene
	private int x;
	//next scene
	private int y;


	void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Cube Count = " + count.ToString ();
		if (count >= 14) {
			AdvanceScene ();
		}
	}

	void AdvanceScene () {
		x = SceneManager.GetActiveScene ().buildIndex;
		y = x + 1;
		SceneManager.LoadScene (y);
	}

}