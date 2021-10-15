using UnityEngine;
using System.Collections;

public class LevelMovement2 : MonoBehaviour {

	public float runSpeed = 3.0f;
	// Use this for initialization
	void Start () {
		Debug.Log("LevelMovement script checking in!");
	}
	int timer = 0;
	public int timeToWait = 120;
	public bool hitObstacle = false;
	// Update is called once per frame
	void Update () {
		// wait 3 seconds
		if (Time.realtimeSinceStartup >= 3) {
			// move forward
			if (!hitObstacle)
				transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
			else {
				// move back if obstacle is hit
				transform.Translate(Vector3.right * runSpeed / 2 * Time.deltaTime);
				// wait 120 frames then move forward again.
				if(timer <= timeToWait)
					timer++;
				else {
					hitObstacle = false;
					timer = 0;
				}
			}
		}

	}
	/* Deprecated, moved to another script.
	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("Player hit the Obstacle!");
		// you could add a health and dmg function here.
	} */
}
