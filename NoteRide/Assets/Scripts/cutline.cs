using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutline : MonoBehaviour {
	LineRenderer cutl;
	public GameObject[] pencils;
	GameObject pencil;
	public GameObject ink;
	int i=55;
	List<Vector3> penpos;
	// Use this for initialization
	void Start () {
		cutl = GetComponent<LineRenderer> ();
		penpos = new List<Vector3> ();
		Invoke ("intial", 0.5f);

	}
	
	// Update is called once per frame
	void Update () {
		penpos.Add (pencil.transform.position);
		//print (penpos.Count);
		if (i > 0) {
			i--;
		}
		if (i == 0) {
			Vector3 pos = penpos [0];
			pos.y = 0.0f;
			Instantiate (ink, pos, Quaternion.identity);
			penpos.RemoveAt (0);
		}
		
	}

	void intial(){
		for (int k = 0; k < pencils.Length; k++) {
			if (pencils [k].active) {
				pencil = pencils [k];
				break;
			}
		}
	}
}
