using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highscore : score{
	public Text Hscore, books;
	// Use this for initialization
	void Start () {
		Hscore.text = a.ToString ("0");
		books.text = A.ToString ("0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
