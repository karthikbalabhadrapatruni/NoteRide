using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {



	// Use this for initialization
	Button btn;
	static public bool pau=false;
	void Start () {
		btn = GetComponent<Button> ();
		btn.onClick.AddListener (StopTime);
		//StopTime ();
	}

	public void StopTime()
	{

		//to pause game
		Time.timeScale = 0f;
		pau=true;


	}


}