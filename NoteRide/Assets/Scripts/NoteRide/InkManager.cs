using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkManager : pencil1 {

	public GameObject inkPrefab;
	public GameObject[] era;
	GameObject er;
	List<GameObject> inkObjectsInScene;
	LineRenderer line;



	void Start(){
		line = GetComponent<LineRenderer> ();
		inkObjectsInScene= new List<GameObject> ();
		Invoke ("intial", 0.5f);
	}

	float t;
	float t2 = 0.25f;
	void Update(){
		t += Time.deltaTime;
		if (t > t2) {
			t = 0;
			AddInk ();
		}


	}

	void AddInk(){
		GameObject ink;
		Vector3 pos = transform.position;
		pos.y = inkPrefab.transform.localScale.y;


		ink =  GameObject.Instantiate (inkPrefab, pos, Quaternion.identity);
		inkObjectsInScene.Add (ink);
		try{
		if ((pos.x - inkObjectsInScene [inkObjectsInScene.Count - 3].transform.position.x > 3)  && (inkObjectsInScene.Count != 0) ) {
			if (z1 == z ) {
				for (float i = inkObjectsInScene [inkObjectsInScene.Count - 2].transform.position.x; i < pos.x; i=i+0.1f) {
						
					//if ((z1 == z) /*&& (i > er.transform.position.x+50)*/) {
						Vector3 p = new Vector3 (i, pos.y, pos.z);
						//only in lanes with position 


							float f=(float)System.Math.Round(pos.z,1);
							if( f ==-1.0f) {
								ink = GameObject.Instantiate (inkPrefab, p, Quaternion.identity);
								inkObjectsInScene.Add (ink);
							}
							
							if(f == -5.2f){
								ink = GameObject.Instantiate (inkPrefab, p, Quaternion.identity);
								inkObjectsInScene.Add (ink);
							}
							if (f == 3.2f) {
								ink = GameObject.Instantiate (inkPrefab, p, Quaternion.identity);
								inkObjectsInScene.Add (ink);
							}
									
					//}

							
				}
			} else {
				z1 = z;
				}
			}
		}catch{
		}


	
		ReconstructLine ();
	
	}

	public void RemoveInk(GameObject go){
		int i =inkObjectsInScene.IndexOf (go);
		for (int j = i; j >0 ; j--) {
			GameObject t = inkObjectsInScene [j];


			inkObjectsInScene.Remove (t);
			Destroy (t);
		}
		inkObjectsInScene.Remove (go);
		Destroy (go);
		ReconstructLine ();
	}

	void LineHasChanged(){
		//remove lines untill the one player just removed
		//reconstruct the line
	
	}



	void ReconstructLine (){
		
		Vector3[] positions = new Vector3[inkObjectsInScene.Count+1];

		for  (int i =0 ; i < positions.Length-1; i++) {
			
			positions[i] = inkObjectsInScene[i].transform.position;




		}
	
		Vector3 penPos = transform.position;
		penPos.y = 0.1f;
		positions [inkObjectsInScene.Count] = penPos;

		line.numPositions = positions.Length;
		line.SetPositions (positions);

	}

	void intial(){
		for (int k = 0; k < era.Length; k++) {
			if (era [k].active) {
				er = era [k];
				break;
			}
		}
	}

		

		

}
