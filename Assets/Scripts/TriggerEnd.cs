using UnityEngine;
using System.Collections.Generic;

public class TriggerEnd : MonoBehaviour {

	public List<GameObject> cameras;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider) {
		for(int i = 0; i < 2; i++) {
			if(cameras[i].name == "Cinematic")
				cameras[i].SetActive(true);
			else
				cameras[i].SetActive(false);
			Debug.Log("camera change triggered");
		}
	}
}
