using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public GameObject level;
	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("An obstacle has been hit!");
		//level.GetComponent<LevelMovement>().hitObstacle = true;
	}
}
