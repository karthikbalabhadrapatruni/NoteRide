using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eraserconfirm : MonoBehaviour {
	public GameObject[] erasers;
	GameObject eraser;
	Button b;

	string ername;
	// Use this for initialization
	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (selecteraser);
	}
	
	// Update is called once per frame


	void selecteraser(){
		for (int i = 0; i < erasers.Length; i++) {
			
			if (erasers [i].active) {
				eraser = erasers [i];
			}
		}
		PlayerPrefs.SetString ("ername",eraser.name);
		SceneManager.LoadScene ("NoteRide");
	}



	void Update () {

	}
}
