using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * Time.deltaTime);
	}
}
