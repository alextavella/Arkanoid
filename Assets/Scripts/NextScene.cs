using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	public string Scene;

	void Update () {
		if (Input.GetButtonDown (UI.Inputs.Fire)) {
			SceneManager.LoadScene (Scene);
		}
	}
}
