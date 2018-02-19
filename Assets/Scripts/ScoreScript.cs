using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text txScore;

	// Update is called once per frame
	void Update () {
		txScore.text = "Score " + UI.Game.GetScore ();
	}
}
