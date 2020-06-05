using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latexprod : MonoBehaviour {
	public GameObject latex;
	GameObject e;
	public GameObject[] era;
	float[] choosez=new float[3];
	static int i=7000;

	// Use this for initialization
	void Start () {
		choosez [0] = -5.2f;
		choosez [1] = -1.0f;
		choosez [2] = 3.2f;
		Invoke ("intial", 0.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (i == 0) {
			try{
			Vector3 pos = new Vector3 ();
			pos.z = choosez [Random .Range(0, choosez.Length)];
			pos.x = e.transform.position.x + 100;
			pos.y = 1.86f;
			Instantiate (latex, pos, Quaternion.Euler (new Vector3 (-30, 0,0)));
			i = 6000;
			}
			catch{
			}

		} else {
			i--;
		}
	}

	void intial(){	
		for (int i = 0; i < era.Length; i++) {
			if (era [i].active) {
				e = era[i];
				break;
			}
		}
	}
}
