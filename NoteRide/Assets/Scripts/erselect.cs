using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erselect : MonoBehaviour {
	public GameObject[] g;
	bool find=false;
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < g.Length; i++) {
			if (g [i].name == PlayerPrefs.GetString ("ername")) {
				g [i].SetActive (true);
				find = true;
				break;
			}
		}
		if (find == false) {
			for (int i = 0; i < g.Length; i++) {
				if (g [i].name == "eraser") {
					g [i].SetActive (true);
					find = true;
					break;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
