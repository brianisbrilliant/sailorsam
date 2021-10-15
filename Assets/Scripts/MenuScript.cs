using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    private static MenuScript instanceRef;

    void Awake() {
        if(instanceRef == null) {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            DestroyImmediate(gameObject);
    }

    bool paused = false;
	void Update () {
        // changing scenes
		if(Input.GetKeyDown(KeyCode.Alpha1))
			Application.LoadLevel("scene1");
		if(Input.GetKeyDown(KeyCode.Alpha2))
			Application.LoadLevel("scene2");
		if(Input.GetKeyDown(KeyCode.Alpha3))
			Application.LoadLevel("scene3");
		if(Input.GetKeyDown(KeyCode.Alpha4))
			Application.LoadLevel("scene0");
        // quitting and pausing
		if(Input.GetKeyDown(KeyCode.Q))
			Application.Quit();
		if(Input.GetKeyDown(KeyCode.Escape))
        	paused = !paused;
        if(paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
	}
 }
