using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penselect : MonoBehaviour {
	public GameObject[] g;
	bool find=false;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < g.Length; i++) {
			if (g [i].name == PlayerPrefs.GetString ("pname")) {
				g [i].SetActive (true);
				find = true;
				break;
			}
		}
		if (find == false) {
			for (int i = 0; i < g.Length; i++) {
				if (g [i].name == "pencil") {
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
