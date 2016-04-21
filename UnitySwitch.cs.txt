using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public Camera MainCamera;
	public Camera Camera1;
	public Camera Camera2;
	public Camera Camera3;
	// Use this for initialization
	void Start () {
		Camera1.enabled = false;
		Camera2.enabled = false;
		Camera3.enabled = false;
		MainCamera.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Keypad2)) {
			if (MainCamera.enabled == false) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				MainCamera.enabled = true;
			}
		}
		if (Input.GetKey (KeyCode.Keypad1)) {
			if (Camera2.enabled == false) {
				Camera1.enabled = false;
				Camera2.enabled = true;
				Camera3.enabled = false;
				MainCamera.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad3)) {
			if (Camera3.enabled == false) {

				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = true;
				MainCamera.enabled = false;
			}
		}
	}
}
