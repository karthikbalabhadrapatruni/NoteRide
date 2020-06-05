using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slider : MonoBehaviour {
	 Slider sd;
	public AudioSource audioclip;
	// Use this for initialization
	void Start () {
		sd = GetComponent<Slider> ();
		sd.onValueChanged.AddListener (delegate{volume();});
	
	}

	// Update is called once per frame
	void volume () {
		audioclip.volume = sd.value;
	}
}
