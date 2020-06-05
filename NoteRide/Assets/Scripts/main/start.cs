using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class start : eraser1 {
	// Use this for initialization
	Button bt;
	public Animator animator;



	void Start () {
		bt = GetComponent<Button> ();
		bt.onClick.AddListener (Taskonclick);
	}


	 void Taskonclick()
	{
		//FadeToLevel (1);
		Time.timeScale = 1;
		isdead = false;
		T = true;
		EnteredTrig=false;
		bombcount = 0;
		a = 0;
		A = 0;
		SceneManager.LoadScene ("loading");

	}

}