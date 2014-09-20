﻿using UnityEngine;
using System;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public int spawnX = 0;
	public int spawnY = 11;
	public int spawnZ = 0;
	public GUIText scoreText;

	private int score = 0;
	private bool shouldRespawn = false;

	void Start() {
		scoreText.enabled = false;
	}

	// Update is called before the engine renders a frame
	void Update() {
	}
	
	// FixedUpdate is called before the engine makes any physics calculations
	void FixedUpdate()
	{
		if (shouldRespawn) {
			transform.position = new Vector3( spawnX, spawnY, spawnZ );
			transform.rotation = new Quaternion( 0, 0, 0, 0 );
			rigidbody.velocity = new Vector3( 0, 0, 0 );
			rigidbody.rotation = Quaternion.identity;
			shouldRespawn = false;
		} else {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
	}

	// triggered on collision before physics performs a collision.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "OutOfBounds") 
		{
			shouldRespawn = true;
			score += 1;
			scoreText.text = "Score: " + score.ToString();
			scoreText.enabled = true;
		}
	}
}
