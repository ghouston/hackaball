using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject objectToFollow;
	public float offsetX;
	public float offsetY;
	public float offsetZ;

	// LateUpdate is called once per frame after all Update
	void LateUpdate () {
		this.transform.position = new Vector3( 
      		objectToFollow.transform.position.x + offsetX, 
      		objectToFollow.transform.position.y + offsetY,
      		objectToFollow.transform.position.z + offsetZ);
	}
}
