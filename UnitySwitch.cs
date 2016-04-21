using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public Camera Camera1;
	public Camera Camera2;
	public Camera Camera3;
	public Camera Camera4;
	public Camera Camera5;
	public Camera Camera6;
	public Camera Camera7;

	// Use this for initialization
	void Start () {
		Camera1.enabled = true;
		Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
		Camera7.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Keypad1)) {
			if (Camera2.enabled == false) {
				Camera1.enabled = false;
				Camera2.enabled = true;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad2)) {
			if (Camera1.enabled == false) {
				Camera1.enabled = true;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad3)) {
			if (Camera3.enabled == false) {

				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = true;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = false;
				MainCamera.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad4)) {
			if (Camera4.enabled == false) {
				
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = true;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad5)) {
			if (Camera5.enabled == false) {
				
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = true;
				Camera6.enabled = false;
				Camera7.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad6)) {
			if (Camera6.enabled == false) {
				
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = true;
				Camera7.enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Keypad7)) {
			if (Camera7.enabled == false) {
				
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera4.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = true;
			}
		}
	}
}
