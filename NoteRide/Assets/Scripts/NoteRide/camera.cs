using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera: MonoBehaviour {
	private CharacterController cc;
	private float speed = 150.0f;
	private Vector3 mv;
	public float acceleration=2.0f;


	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();

	}

	// Update is called once per frame
	void Update () {
		//to move camera with speed of eraser
		if (speed <= 350) {
			speed += Time.deltaTime * acceleration;
		}
		mv = Vector3.zero;
		mv.x = speed / 5;
		cc.Move (mv * Time.deltaTime);
	}
	
}