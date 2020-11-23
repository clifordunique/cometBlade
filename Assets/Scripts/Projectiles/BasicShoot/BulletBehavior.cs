﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
	float moveSpeed = 10f;

	private Rigidbody2D rb;

	private GameObject target;
	private Vector2 moveDirection;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.Find ("Player");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		Destroy (gameObject, 3f);
		
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag != ("Enemy")) {
			//Debug.Log ("Hit!");
			Destroy (gameObject);
		}

		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}