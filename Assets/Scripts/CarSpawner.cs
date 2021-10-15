using UnityEngine;
using System.Collections.Generic;
using Random = System.Random;

public class CarSpawner : MonoBehaviour {

	public int interval = 80;
	public List<GameObject> cars;
	// Use this for initialization
	void Start () {

	}

	int timer;
	void FixedUpdate () {
		timer++;
		if(timer >= interval) {
			Debug.Log("The timer has executed.");
			timer = 0;
			Spawner();
		}
	}

	void Spawner() {
		Random rNum = new Random();
		Instantiate(cars[rNum.Next(0,4)], transform.position, transform.rotation);
	}
}
