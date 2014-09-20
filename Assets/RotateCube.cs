using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	public int rotateX;
	public int rotateY;
	public int rotateZ;

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime);
	}
}
