using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencil1: MonoBehaviour {
	private CharacterController cc;
	private float speed =150.0f;
	private Vector3 mv;
	//private float vv = 0.0f;
	private float gravity = 12.0f;
	public float acceleration=2.0f;
	Rigidbody rb;
	private float[] choosez;
	//public CharacterController er;

	static public float z;
	public int lanesCount = 3;
	bool didChangeLastFrame = false;
	public float laneDistance = 4.2f;
	public float firstLaneXPos = 20;
	public float deadZone = 0.1f;
	public float sideSpeed = 5;
	//float jump=100.0f;
	int i=100;
	static public float z1;
	bool ground=false;
	int f=0;

	//private LineRenderer l;



	// Use this for initialization
	void Start () {
		choosez = new float[3];
		choosez [0] = 0;
		choosez [1] = 1;
		choosez [2] = 2;


		cc = GetComponent<CharacterController> ();


	}

	// Update is called once per frame
	void Update () {
		// to move
		i--;
		mov ();
		if (speed <= 350) {
			speed += Time.deltaTime * acceleration;
		}
		mv = Vector3.zero;
		mv.x = speed / 5;
		Vector3 pos = transform.position;
		pos.z = Mathf.Lerp (pos.z, firstLaneXPos + laneDistance * z, Time.deltaTime * sideSpeed);
		transform.position = pos;
		cc.Move (mv * Time.deltaTime);

	}
	void mov()
	{ 
		//randomly chose one lane
		if (i == 0) {
			z = choosez [Random.Range (0, choosez.Length)];
			i=200;
		}
	}


}