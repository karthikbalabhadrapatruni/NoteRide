using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserMovement : MonoBehaviour {

	//public float horizontalSpeed;
	public float forwardSpeed;
	//public float minX;
	//public float maxX;
	public InkManager inkmanager;

	int leftX = -10;
	int midX = 0;
	int rightX = 10;

	Lanes currentLane = Lanes.mid;
	enum Lanes{
	left, mid, right
	}
	float t;
	float duration = 1;
	float targetX;

	void Start(){
		targetX = transform.position.x;


		t = 0.5f;
	}
	void Update(){
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) ){
			//try to move left
			if(currentLane == Lanes.mid){
				currentLane = Lanes.left;
				targetX = leftX;
				t = 0;
			}
			if(currentLane == Lanes.right){
				currentLane = Lanes.mid;
				targetX = midX;
				t = 0;
			}
		}
			else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
			//try to move right
			if(currentLane == Lanes.mid){
				currentLane = Lanes.right;
				targetX = rightX;
				t = 0;
			}
			if(currentLane == Lanes.left){
				currentLane = Lanes.mid;
				targetX = midX;
				t = 0;
			}
		}
		t += Time.deltaTime;
		float xlerp = Mathf.Lerp (transform.position.x, targetX, t/duration);
		transform.position = new Vector3 (xlerp, transform.position.y, transform.position.z);
		transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;

		}

	// Update is called once per frame
	/*void Update () {
		float h = Input.GetAxis ("Horizontal");	

		if (h < 0) {
			transform.position += -Vector3.right * horizontalSpeed * Time.deltaTime;
		} else if (h > 0) {
			transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;	
		}

		if (transform.position.x < minX) {
			transform.position = new Vector3 (minX, transform.position.y, transform.position.z);
		} else if (transform.position.x > maxX) {
			transform.position = new Vector3 (maxX, transform.position.y, transform.position.z);
		}

		transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
	}
*/
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "ink") {
			inkmanager.RemoveInk (col.gameObject);
		}
	}
}
