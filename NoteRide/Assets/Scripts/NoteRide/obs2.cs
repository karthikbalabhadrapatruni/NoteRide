using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs2 : MonoBehaviour {


	public GameObject[] obstacleB;
	private float[] choosez2,choosex2;


	private int randz2;
	public int pp;
	float x2=0.0f,xB=-100.0f;


	// Use this for initialization
	void Start () {
		choosez2 = new float[3];
		choosez2 [0] = -5.2f;
		choosez2 [1] = -1.0f;
		choosez2 [2] = 3.2f;
		choosex2 = new float[3];
		choosex2 [0] = 200.0f;
		choosex2 [1] = 350.0f;
		choosex2 [2] = 500.0f;
		x2 =transform.position.x + choosex2 [Random.Range (0, choosex2.Length)];
		if (Time.timeScale == 1.0f) {
			//instantiate obstacles
			Instantiate (obstacleB [Random.Range (0, obstacleB.Length)], new Vector3 (x2, 0.0f, choosez2 [Random.Range (0, choosez2.Length)]), Quaternion.Euler (new Vector3 (0, 0, 0)));
		}

	}


	// Update is called once per frame
	void Update () {

	}

}

