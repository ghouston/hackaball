using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject objectToFollow;
	public float offsetX;
	public float offsetY;
	public float offsetZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// follow the game object
		this.transform.position = new Vector3( 
      		objectToFollow.transform.position.x + offsetX, 
      		objectToFollow.transform.position.y + offsetY,
      		objectToFollow.transform.position.z + offsetZ);
	}
}
