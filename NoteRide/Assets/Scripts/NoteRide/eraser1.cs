using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class eraser1 : score{

	public Text tex;
	private CharacterController cc;
	public float speed = 150.0f;
	private Vector3 mv;
	private float gravity = 40.0f;
	public float acceleration=2.0f;
	public int laneNumber = 0;
	public int lanesCount = 3;
	public float laneDistance = 4.2f;
	public float firstLaneXPos = -5.2f;
	public float deadZone = 0.1f;
	public float sideSpeed = 5;
	float jump=7.0f;
	Rigidbody rb;
	static public bool isdead = false,T=true, EnteredTrig=false;
	public InkManager[] inks;
	InkManager ink;
	float startTime,endTime,dis;
	Vector2 startPos,endPos;
	int input, f ;
	bool j=false,B = false;
	BoxCollider b;
	protected Animator anim;
	public latexhealth l;
	public timelife tl;
	public GameObject[] g;
	public static int bombcount=0;


	void Start () {
		// Use this for initialization
		cc = GetComponent<CharacterController> ();
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
		anim = GetComponent<Animator> ();
		b = GetComponent<BoxCollider> ();
		Invoke ("intial", 0.1f);
		Time.timeScale = 1;
		isdead = false;
		T = true;
	}

	// Update is called once per frame
	void Update () {
		f = 0;
		if (isdead && T) {
			
			//anim.SetTrigger("end");
			Time.timeScale = 0;
			SceneManager.LoadScene ("highscore");
			T = false;

		} 

		if(isdead==false)
		{
			
		
			if (speed <= 350) {
				//increasing spped and controlling its limit
				speed += Time.deltaTime * acceleration;
			}
			mv = Vector3.zero;

			mv = transform.TransformDirection (mv);


			// getting touch input through mouse input
			if (Input.GetMouseButtonDown (0)) {
				startTime = Time.time;
				startPos = Input.mousePosition;
			

			} else if (Input.GetMouseButtonUp (0)) {
				endTime = Time.time;
				endPos = Input.mousePosition;
				f++;

			}
			dis = (endPos - startPos).magnitude;

			if (dis > 30f) {
				swipe ();

			}
			transPos ();
	

			//for jump in parabolic path
			if (B) {
				Vector3 pos = transform.position;
				pos.y += 0.5f;
				transform.position = pos;
				if (pos.y >= 5.5f) {
					B = false;
				
				}
			}
			if (B == false) {
				//to fall down on ground
				mv.y -= gravity * Time.deltaTime * 10;
			}

		

			mv.x = speed / 5;
			try{
			cc.Move (mv * Time.deltaTime);
			}
			catch{
			}
		}


	}


	public void OnTriggerEnter(Collider cd){

		if (cd.tag .Equals("obs")) {
			//if collides with obstacles
			Death();
			EnteredTrig = true;


		}
		if (cd.tag .Equals("ink")) {
			// to remove ink
			ink.RemoveInk (cd.gameObject);
			scor (0.3f);
			tl.increlife ();
		}

		if(cd.tag.Equals("book")){
			// to collect boooks
			anim.SetTrigger("collect");
			Destroy(cd.gameObject);
			A++;
		}


		if (cd.tag.Equals ("latex")) {
			// to fill latex
			l.fill ();
			Destroy (cd.gameObject);
		}

		if (cd.tag.Equals ("bob")) {
			// to fill latex
			Destroy (cd.gameObject);
			bombcount = bombcount + 1;
			tex.text = bombcount.ToString ("0");
		}

				
	}






	private void Death(){
		//anim.SetTrigger ("end");
		isdead = true;
		dead = true;
		//Time.timeScale = 0;

	}




	private void swipe(){
		//swipe controls to change lane

		Vector2 dis = endPos - startPos;
		if (Mathf.Abs (dis.x) > Mathf.Abs (dis.y)) {
			if (dis.x > 0) {
				input = -1;
			} else if (dis.x < 0) {
				input = 1;
			}
			changeLane ();
		} else if (Mathf.Abs (dis.x) < Mathf.Abs (dis.y)) {
			if (f == 1) {
				j = true;
				f--;
			}

		}

	}



	private void changeLane ()
	{

		
		if (Mathf.Abs (input) > deadZone) {
			
			if (input == 1) {
				if (laneNumber == 0 && f == 1) {
					laneNumber = 1;
					f--;
					anim.SetTrigger ("left");   //animation controller
					input = 0;

						

				} else {
					if (laneNumber == 1 && f == 1) {
						laneNumber = 2;
						f--;
						anim.SetTrigger ("left"); //animation controller
						input = 0;
							

					}
				}
			}


			if (input == -1) {
				if (laneNumber == 2 && f == 1) {
					
					laneNumber = 1;
					f--;
					anim.SetTrigger ("right");   //animation controller
					input = 0;
						

				} else {
					if (laneNumber == 1 && f == 1) {
						
						laneNumber = 0;
						f--;
						anim.SetTrigger ("right");   //animation controller
						input = 0;
							

					}
				}
			}
		}
	}



	void transPos(){
		Vector3 pos = transform.position;
		pos.z = Mathf.Lerp (pos.z, firstLaneXPos + laneDistance * laneNumber, Time.deltaTime * sideSpeed);
		try{
		if (cc.isGrounded) {
			
			if (j) {
				
				anim.SetTrigger ("jump");  //animation controller
				j = false;//to stop jumping twice
				B= true;// to give condition to jump in parabolic path
			}

		}
			transform.position = pos;
		}
		catch{
		}
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
}





