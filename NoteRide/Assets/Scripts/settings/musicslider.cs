using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicslider : MonoBehaviour {
	Slider sd1;
	public AudioSource audioclip1;
	// Use this for initialization
	void Start () {
		sd1 = GetComponent<Slider> ();
		sd1.onValueChanged.AddListener (delegate{volume();});
	}
	
	void volume () {
		audioclip1.volume = sd1.value;
	}
}
