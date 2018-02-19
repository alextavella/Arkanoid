using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		UI.Game.AddScore ();
		Destroy (gameObject);
	}
}
