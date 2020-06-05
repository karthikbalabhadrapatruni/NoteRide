using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverasset : score {
	Text i;
	int abook;
	// Use this for initialization
	void Start () {
		i = GetComponent<Text> ();
		abook = PlayerPrefs.GetInt ("highbooks");
		PlayerPrefs.SetInt ("highbooks", abook +(int) A);
		i.text = PlayerPrefs.GetInt ("highbooks").ToString("0");


	}

	// Update is called once per frame
	void Update () {
	}
}

		