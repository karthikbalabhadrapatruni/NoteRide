using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeTog : MonoBehaviour {

	// Use this for initialization
	Toggle t;
	bool togbut=true;
	public AudioSource myaudio;
	void Start () {
		t = GetComponent<Toggle>();
		t.onValueChanged.AddListener (delegate{volume();});
	}

	void volume(){
		togbut = !togbut;
		if (togbut) {
			myaudio.mute = false;
		} else {
			myaudio.mute = true;
		}
			
	}
	
}
