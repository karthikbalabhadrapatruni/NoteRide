using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour {


	public GameObject[] collect,era;
	private float[] choosez1;
	private GameObject g,er;
	private int randz1;
	float x1 = 0.0f;
	static float A=-100.0f;
	private List<GameObject> activeobs;
	camera Z;
	static int i, j;
	float x;

	void Start () {
		choosez1 = new float[3];
		choosez1 [0] = -5.2f;
		choosez1 [1] = -1.0f;
		choosez1 [2] = 3.2f;
		i = 100;
		j = 100;
		Invoke ("intial", 0.1f);
	}


	// Update is called once per frame
	void Update () {
		if (i == 0) {
			
				x = er.transform.position.x + 150;
				//instantiate collectables
				g = Instantiate (collect [Random.Range (0, collect.Length)], new Vector3 (x, 3.3f, choosez1 [Random.Range (0, choosez1.Length)]), Quaternion.Euler (new Vector3 (90, 180, -40))) as GameObject;
				g.transform.Rotate (Vector3.up, Time.deltaTime * 50);

				i = 1500;


		}else {
			i--;
			}
	}

	void intial(){	
		for (int i = 0; i < era.Length; i++) {
			if (era [i].active) {
				er = era[i];
				break;
			}
		}
	}


}
