using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	
	public float boundary_x;
	public float boundary_y;
	public float speed = 0.01f;

	private Vector3 ballPosition;
	private float direction_x = 1;
	private float direction_y = 1;

	private float boundary_end;
	private float escape = 0.1f;

	// Use this for initialization
	void Start () {
		boundary_end = (boundary_y + escape) * -1;
	}
	
	// Update is called once per frame
	void Update () {
		
		ballPosition = gameObject.transform.position;

		var move_x = ballPosition.x + (speed * direction_x);
		var move_y = ballPosition.y + (speed * direction_y);
		
		move_x = (float)Math.Min(move_x, boundary_x);
		move_x = (float)Math.Max(move_x, boundary_x * -1);

		move_y = (float)Math.Min(move_y, boundary_y);
		move_y = (float)Math.Max(move_y, boundary_end);

		direction_x = (move_x == boundary_x * -1 || move_x == boundary_x) ? direction_x * -1 : direction_x;
		direction_y = (move_y == boundary_y || move_y == boundary_end) ? direction_y * -1 : direction_y;

//		ballPosition.x = move_x;
		ballPosition.y = move_y;
		transform.position = ballPosition;
	}

	void OnCollisionEnter2D(Collision2D c){
		print (c.gameObject);
		print (c.gameObject.tag);
		if (c.gameObject.tag == UI.Tags.Player) {
			direction_y = direction_y * -1;
		}
	}

	void OnColliderEnter2D(Collider2D c) {
		print (c.tag);
		if (c.tag == UI.Tags.Player) {
			direction_y = direction_y * -1;
		}
	}
}
