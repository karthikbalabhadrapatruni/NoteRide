using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : eraser1 {
	float s;
	CharacterController cc1;
	Vector3 mv1;
	public ParticleSystem p;

	// Use this for initialization
	void Start () {
		cc1 = GetComponent<CharacterController> ();
		s = speed;


	}


	public void OnTriggerEnter(Collider cd){

		if (cd.gameObject.tag=="obs") {
			//p.Play();
			//if collides with obstacles
			Destroy(cd.gameObject);
			//delete bomb also
			Destroy (this.gameObject);
		




		}
	}

	
		




	// Update is called once per frame
	void Update () {
		

		mv1.x = s+30 ;
		cc1.Move (mv1 * Time.deltaTime);



		
	}
}
