using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pencilconfirm : MonoBehaviour {
	public GameObject[] pencils;
	GameObject pencil;
	Button b;


	// Use this for initialization
	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (selectpencil);
	}


	void selectpencil(){
		for (int i = 0; i < pencils.Length; i++) {

			if (pencils [i].active) {
				pencil = pencils [i];
			}
		}
		PlayerPrefs.SetString ("pname",pencil.name);
		SceneManager.LoadScene ("NoteRide");
	}



	// Update is called once per frame
	void Update () {
		
	}
}
