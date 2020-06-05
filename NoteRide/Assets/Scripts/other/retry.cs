using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class retry :eraser1 {

	// Use this for initialization
	Button b;

	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (Taskonclick);
	}

	void Taskonclick()
	{
		Time.timeScale = 1;
		isdead = false;
		T = true;
		EnteredTrig=false;
		bombcount = 0;
		a = 0;
		A = 0;
		SceneManager.LoadScene ("NoteRide");

	}
}

