using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public Text scoreText;
	public Text book;
	static public float a=0;
	static public float A=0;
	float c;
	static public bool dead=false;
	static public int highscore;
	static public int highbooks;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		scoreText.text = a.ToString ("0");
		book.text = A.ToString ("0");
		if (dead) {
			
			//Time.timeScale = 0;
			}

		

	}
	public void scor(float b){
		a =a+ b;

	}
		
}
