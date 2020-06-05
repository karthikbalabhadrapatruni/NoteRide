using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRemainingInk : MonoBehaviour {

	public InkManager[] inks;
	InkManager ink;
	public GameObject[] g;

	void Start(){
		
		Invoke ("intial", 0.1f);
	}

	void intial(){
		int i=0;

		for ( i = 0; i < inks.Length; i++) {

			if (g [i].active) {

				break;
			}
		}

		ink=inks[i];
	}
	public void OnTriggerEnter(Collider cd){
		//to destroy remaining things by cube
		if (cd.gameObject.tag == "ink") {
			ink.RemoveInk (cd.gameObject);


		}
		if (cd.gameObject.tag == "obs") {
			Destroy (cd.gameObject);

		}

		if (cd.gameObject.tag == "book") {
			Destroy (cd.gameObject);

		}
	}
}
