using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class resume :pause {



	// Use this for initialization
	Button B;

	void Start () {
		Time.timeScale = 1;
		B = GetComponent<Button> ();
		B.onClick.AddListener (Taskonclick);
	}

	void Taskonclick()
	{
		//print (Time.timeScale);
		pau=false;
		Time.timeScale = 1f;
		//print (Time.timeScale);

	}
}