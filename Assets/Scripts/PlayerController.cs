using UnityEngine;
using System;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;
	public int spawnY = 1;

	// Update is called before the engine renders a frame
	void Update() {
	}
	
	// FixedUpdate is called before the engine makes any physics calculations
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		if (moveHorizontal != 0.0) { 
			Debug.Log(String.Format("moveHorizontal {0}", moveHorizontal));
		}
		if (moveVertical != 0.0) { 
			Debug.Log(String.Format("moveVertical {0}", moveVertical)); 
		}
		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	// triggered on collision before physics performs a collision.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "OutOfBounds") 
		{

			transform.position = new Vector3( 0, spawnY, 0 );
			rigidbody.velocity = new Vector3( 0, 0, 0 );
		}
	}
}
