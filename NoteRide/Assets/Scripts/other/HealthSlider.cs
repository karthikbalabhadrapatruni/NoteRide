using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthSlider : MonoBehaviour {
	public static float maxHealth = 200;
	public static float curHealth = 100;
	public float restoreHealth = 20.0f;  
	public Slider HSlider;
	public bool i=false;
	// Use this for initialization
	void Start () {
		HSlider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (curHealth < maxHealth  )
		{
			AdjustCurrentHealth(restoreHealth * Time.deltaTime);
		}
	}

	void AdjustCurrentHealth(float adj){
	
	
	}
}
