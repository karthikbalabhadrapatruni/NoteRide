﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class settings : MonoBehaviour {

	// Use this for initialization
	Button b;

	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (Taskonclick);
	}

	void Taskonclick()
	{
		SceneManager.LoadScene ("settings");
//		Application.LoadLevel("settings");
	}
}

