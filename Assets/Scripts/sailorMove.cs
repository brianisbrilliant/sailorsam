using UnityEngine;
using System.Collections;

public class sailorMove : MonoBehaviour {

	// to test if i can still move right or left
	public bool leftBound = true;
 	public bool rightBound = true;

	void Update () {
		if(Input.GetKey(KeyCode.A) && leftBound) {
			transform.Translate(Vector3.left * Time.deltaTime);

		}
		if(Input.GetKey(KeyCode.D) && rightBound) {
			transform.Translate(Vector3.right * Time.deltaTime);
		}
	}

	// if player is too far left or right, stop movement in that direction
	void OnTriggerEnter(Collider collider) {
		Debug.Log("Triggered!");
		if(collider.tag == "leftBound")
			leftBound = false;
		if(collider.tag == "rightBound")
			rightBound = false;
		if(collider.tag == "Obstacle")
			Time.timeScale = 0;
			Debug.Log("You've been hit by a car!");
			Debug.Log("Restart?");
			if(Input.GetKeyDown(KeyCode.Space))
				Application.LoadLevel("scene3");
	}

	// if player moves away from bounds, resume movement in that direction.
	void OnTriggerExit(Collider collider) {
		if(collider.tag == "leftBound")
			leftBound = true;
		if(collider.tag == "rightBound")
			rightBound = true;
	}
}
