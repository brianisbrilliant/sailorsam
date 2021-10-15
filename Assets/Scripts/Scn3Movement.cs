using UnityEngine;
using System.Collections;

public class Scn3Movement : MonoBehaviour {

	// variables
	public float speed = .5f;

	void Update() {
		transform.Translate(Vector3.forward * speed * -Time.deltaTime);
	}
}
