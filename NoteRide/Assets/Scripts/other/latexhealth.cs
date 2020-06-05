using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class latexhealth : pause {
	Slider s;
	// Use this for initialization
	void Start () {
		s = GetComponent<Slider> ();
		s.value = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (pau == false) {
			s.value -= 0.05f;
			if (s.value <= 0) {
				Time.timeScale = 0;
				SceneManager.LoadScene ("highscore");
			}
		}

		
	}

	public void fill(){
		//to fill latex value
		s.value = 100;
	}
}
