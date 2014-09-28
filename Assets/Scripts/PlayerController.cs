   using UnityEngine;
using System;
using System.Collections;

public class PlayerController : MonoBehaviour
{
		public float speed;
		public float horizontalSpeed = 2.0F;
		public float verticalSpeed = 2.0F;
		public int spawnX = 0;
		public int spawnY = 11;
		public int spawnZ = 0;
		private int score = 0;
		public GUIText scoreText;

		private bool shouldRespawn = false;

		void Start ()
		{
				scoreText.enabled = false;
		}

		// Update is called before the engine renders a frame
		void Update ()
		{
		}
	
		// FixedUpdate is called before the engine makes any physics calculations
		void FixedUpdate ()
		{
				if (transform.position.y < -100) {
						shouldRespawn = true;
				}
				if (shouldRespawn) {
//			StopCoroutine("handleGoal");
						transform.position = new Vector3 (spawnX, spawnY, spawnZ);
						transform.rotation = new Quaternion (0, 0, 0, 0);
						rigidbody.velocity = new Vector3 (0, 0, 0);
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
		void OnTriggerEnter (Collider other)
		{
				if (other.gameObject.tag == "OutOfBounds") {
						shouldRespawn = true;
						score += 1;
						scoreText.text = "Score: " + score.ToString ();
						scoreText.enabled = true;
				} else if (other.gameObject.tag == "Note1") {
						scoreText.text = "PLAY SOUND!";
						scoreText.enabled = true;
						other.audio.Play ();
				}
		}
}
