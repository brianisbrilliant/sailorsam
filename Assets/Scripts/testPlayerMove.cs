using UnityEngine;
using System.Collections;

public class testPlayerMove : MonoBehaviour {

	public float jumpHeight = 350f;
	public Animation anim;
	public Rigidbody2D player;
	public int jumpTimer;
	public int jumpWait = 75;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
	}

	// Update is called once per frame
	void Update () {
		jumpTimer++;
		if(Input.GetKeyDown(KeyCode.Space) && jumpTimer >= jumpWait) {
			player.AddForce(Vector2.up * jumpHeight);
			anim.Play("Jump");
			anim.PlayQueued("Run");
			jumpTimer = 0;
		}

		if(Input.GetKeyDown(KeyCode.LeftShift)) {
			anim.Play("Slide");
			anim.PlayQueued("Run");
		}
	}
}
