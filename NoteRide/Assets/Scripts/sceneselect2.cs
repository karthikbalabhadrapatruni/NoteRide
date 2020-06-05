using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneselect2 : eraser1 {
	Button b;
	// Use this for initialization
	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (changescene);
	}

	// Update is called once per frame
	void Update () {

	}

	void changescene(){
		//FadeToLevel (1);
		Time.timeScale = 1;
		isdead = false;
		T = true;
		EnteredTrig=false;
		bombcount = 0;
		a = 0;
		A = 0;
		SceneManager.LoadScene ("bridgescene");
	}
}
