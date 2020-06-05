using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameoverscore : score {
	Text i;

	// Use this for initialization
	void Start () {
		i = GetComponent<Text> ();
		if (a > PlayerPrefs.GetInt ("highscore")) {
			highscore = (int)a;
			PlayerPrefs.SetInt ("highscore", highscore);

		}
		i.text =a.ToString ("0");
	


	}
	
	// Update is called once per frame
	void Update () {
	}
}
