using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMAnager1 : MonoBehaviour {
	public GameObject[] tilePrefabs;
	private Transform playerTransform;
	private float spawnX = -21.3f;
	private float tileLength=39.4f;
	private int amnTilesOnScreen =7;
	private float safezone=70f;
	private List<GameObject> activeTiles;
	// Use this for initialization
	void Start () {
		activeTiles = new List<GameObject> ();
		for (int i = 0; i < amnTilesOnScreen; i++) {
			SpawnTile ();
			Invoke ("initial", 0.1f);

		}
	}

	// Update is called once per frame
	void Update () {
		try{
		if(playerTransform.position.x- safezone >(spawnX-amnTilesOnScreen*tileLength)){
			
			SpawnTile();
			DeleteTile ();
		}
		} catch{
		}
	}

	void SpawnTile (int prefabIndex = -1)
	{
		//to spanw tiles
		GameObject go;
		go = Instantiate (tilePrefabs [0]);
		go.transform.SetParent (transform);
		go.transform.position = Vector3.right* spawnX;
		spawnX += tileLength;
		activeTiles.Add (go);



	}

	void DeleteTile(){
		//delete behind tiles
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}


	void initial(){
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

	}
}
