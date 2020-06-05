using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class bombthrowlamp : eraser1 {

	public GameObject bmb;
	public Text t;
	public Button b1;
	GameObject er;
	public GameObject[] ers;
	public Animator a;
	int x;
	// Use this for initialization
	void Start () {

		Invoke ("intial", 0.1f);
		//b1 = GetComponent<Button> ();
		b1.onClick.AddListener (clic);

	}

	// Update is called once per frame
	void Update () {

	}


	void clic(){
		print ("hii");
		print (bombcount);
		if (bombcount > 0) {
			//ani = true;

			Instantiate (bmb, er.transform.position, Quaternion.identity);
			a.SetTrigger ("bomb");
			bombcount--;
			t.text = bombcount.ToString ("0");
		}
	}


	void intial(){

		for (int k = 0; k < ers.Length; k++) {
			if (ers [k].active) {
				er = ers [k];
				break;
			}
		}
	}
}
