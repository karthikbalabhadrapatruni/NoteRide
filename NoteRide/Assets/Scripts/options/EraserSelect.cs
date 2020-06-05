using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EraserSelect : MonoBehaviour {
	Button b;

	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (Taskonclick);
	}

	void Taskonclick()
	{
		SceneManager.LoadScene("erasers");
	}
}