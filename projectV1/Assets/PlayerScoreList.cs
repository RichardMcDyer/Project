using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreList : MonoBehaviour {

	public GameObject playerScoreEntryPrefab;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 5; i++) {
			GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);
			go.transform.SetParent (this.transform);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
