using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlinkScript : MonoBehaviour {

	public float interval;

	IEnumerator Start()
	{	
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(interval);

		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(interval);

		StartCoroutine(Start());
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene(UI.Scenes.Game);
		}
	}
}
