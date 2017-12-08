/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	Dictionary<string, int> playerScores;

	void Start() {
		
	}
	void Init(){
		if (playerScores != null)
			return;
		
		playerScores = new Dictionary<string, int> ();
	}

	public int GetScore(string username) {
		Init ();

		if (playerScores.ContainsKey (username) == false) {
			return 0;
		}
		return playerScores [username];
	}

//	public void SetScore(string username, int value) {
		Init ();
		if(playerScores.ContainsKey (username) == false) {
			playerScores [username] = new Dictionary<string, int> ();
		}
		playerScores [username] = value;
	}

	public void ChangeScore(string username, int amount){
		Init ();
		int currScore = GetScore (username);
		SetScore (username, currScore + amount);
	}

}*/
