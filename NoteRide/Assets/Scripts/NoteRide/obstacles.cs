using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour {
	
	public GameObject[] obstacle;
	private float[] choosez,choosex;
	private int randz;
	public int pp;
	float x=0.0f;




	// Use this for initialization
	void Start () {
		choosez = new float[3];
		choosez [0] = -5.2f;
		choosez [1] = -1.0f;
		choosez [2] = 3.2f;
		choosex = new float[3];
		choosex [0] = 200.0f;
		choosex [1] = 350.0f;
		choosex [2] = 500.0f;
		x = transform.position.x + choosex [Random.Range (0, choosex.Length)];
		//instantiate obstacles
		if (Time.timeScale == 1.0f) {
			Instantiate (obstacle [Random.Range (0, obstacle.Length)], new Vector3 (x, 1.43f, choosez [Random.Range (0, choosez.Length)]), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
			
	}
		

}


  