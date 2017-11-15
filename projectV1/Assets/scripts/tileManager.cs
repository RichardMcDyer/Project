﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {

	public GameObject[] tilePrefabs; 

	private Transform playerTransform; 
	private float spawnZ = -11.0f;
	private float tileLenght = 11.0f;
	private float safeZone = 15.0f;
	private int amtTilesOnScreen = 10; 
	private int lastPrefabIndex = 0;

	private List<GameObject> activeTiles;



	// Use this for initialization
	void Start () {
		activeTiles = new List<GameObject> (); 
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		for (int i = 0; i < amtTilesOnScreen; i++) {
			SpawnTile ();
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (playerTransform.position.z - safeZone > (spawnZ - amtTilesOnScreen * tileLenght)) {
			SpawnTile ();
			DeleteTile ();
		}
		
	}

	void SpawnTile(int prefabIndex = -1){
		GameObject go;

		go = Instantiate (tilePrefabs [RandomPrefabIndex()]) as GameObject;


 
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLenght;
		activeTiles.Add (go);
	}

	void DeleteTile(){
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex(){
		if (tilePrefabs.Length <= 1)
			return 0;

		int randomIndex = lastPrefabIndex;
		while (randomIndex == lastPrefabIndex) {
			randomIndex = Random.Range (0, tilePrefabs.Length);
		} 

		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}
