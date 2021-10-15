
using UnityEngine;
using System.Collections;



public class Sinking : MonoBehaviour 
{
	float sink = 100f;
	bool triggered = false;

	void Update() {
		if (triggered) {
			transform.Translate (Vector3.down * 0.1f * Time.deltaTime);
			transform.Translate (Vector3.right * 0.5f * Time.deltaTime);
		}
	}


	void OnTriggerEnter (Collider col)
	{
		if(col.tag == "Player")
		{
				triggered = true;
		}

	}
	
	
}
