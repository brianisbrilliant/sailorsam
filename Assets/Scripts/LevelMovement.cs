using UnityEngine;
using System.Collections;

public class LevelMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("LevelMovement script checking in!");
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 2 * Time.deltaTime);
	}
}
