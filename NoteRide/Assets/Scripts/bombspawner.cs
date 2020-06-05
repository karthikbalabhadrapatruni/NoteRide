using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombspawner : MonoBehaviour {
	public GameObject bmb;
	GameObject e;
	public GameObject[] era;
	float[] choosez=new float[3];
	static int i=1000;

	// Use this for initialization
	void Start () {
		choosez [0] = -5.2f;
		choosez [1] = -1.0f;
		choosez [2] = 3.2f;
		Invoke ("intial", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		try{
			if (i == 0 && Time.timeScale==1.0f) {
			Vector3 pos = new Vector3 ();
			pos.z = choosez [Random .Range(0, choosez.Length)];
			pos.x = e.transform.position.x + 100;
			pos.y = 3.25f;
			Instantiate (bmb, pos, Quaternion.Euler (new Vector3 (-30, 0,0)));
			i = 3000;

		} else {
			i--;
		}
		}catch{
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
