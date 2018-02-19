using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;

	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		UI.Game.Stop ();
		UI.Game.SetMaxScore (10);
		UI.Game.Reset ();
	}

	void Update() {
		
		if (Input.GetButtonDown (UI.Inputs.Fire) && !UI.Game.Started()) {
			UI.Game.Start ();
			rb.velocity = Vector2.up * speed;
		}

		if (UI.Game.Started ()) {
			rb.velocity = speed * (rb.velocity.normalized);
		}
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
		return (ballPos.x - racketPos.x) / racketWidth;
	}

	void OnCollisionEnter2D(Collision2D col) {
		
		if (col.gameObject.tag == UI.Tags.Player) {

			float x = hitFactor (transform.position,
				          col.transform.position,
				          col.collider.bounds.size.x);

			Vector2 dir = new Vector2 (x, 1).normalized;
			rb.velocity = dir * speed;

		} else if (col.gameObject.tag == UI.Tags.Finish) {
			
			UI.Game.Stop ();
			rb.velocity = new Vector2 (0.0f, 0.0f);

			SceneManager.LoadScene(UI.Scenes.Intro);
		}
	}
}
