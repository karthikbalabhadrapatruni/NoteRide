using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenAI : MonoBehaviour {

	public float a,b,c;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 ((Mathf.Sin (transform.position.z/b * a) * c), 0, speed) * Time.deltaTime;	
	}
}
