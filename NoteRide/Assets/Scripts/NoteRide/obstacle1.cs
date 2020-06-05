using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle1 : MonoBehaviour {
	
	public GameObject[] obstacleA;
	private float[] choosez1,choosex1;
	private GameObject g;


	private int randz1;
	public int pp;
	float x1 = 0.0f;
	static float A=-100.0f;
	private List<GameObject> activeobs;


	void Start () {
		choosez1 = new float[3];
		choosez1 [0] = -5.2f;
		choosez1 [1] = -1.0f;
		choosez1 [2] = 3.2f;
		choosex1 = new float[3];
		choosex1 [0] = 200.0f;
		choosex1 [1] = 300.0f;
		choosex1 [2] =400.0f;
		activeobs = new List<GameObject> ();
		//GameObject g;
		x1 = transform.position.x + choosex1 [Random.Range (0, choosex1.Length)];
		if (A <= x1 - 200 && Time.timeScale==1.0f) {
			//instantiate obstacles
			 Instantiate (obstacleA [Random.Range (0, obstacleA.Length)], new Vector3 (x1, 1.63f, choosez1 [Random.Range (0, choosez1.Length)]), Quaternion.Euler (new Vector3 (0, 90, 0)));
		

		}
		A = x1;



	}


	// Update is called once per frame
	void Update () {

	}



}

