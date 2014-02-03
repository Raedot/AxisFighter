using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public Vector3 topPos;
	public Vector3 sidePos;
	public float speed;
	public bool isOnTop;

	// Use this for initialization
	void Start () {
		isOnTop = true;
		animation.Stop ();
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown ("z")) {
			toggleCameraPos();
		}

		if (isOnTop) {

			//animation.Play ("Animations/CameraMoveSide", PlayMode.StopAll);
		} else {

			//animation.Play ("Animations/CameraMoveTop", PlayMode.StopAll);
		}

		/*if (isOnTop) {

			transform.position = topPos;//Vector3.Lerp (sidePos, topPos, speed * Time.deltaTime);
			Quaternion target = Quaternion.Euler(new Vector3(90,0,0));
			transform.rotation = Quaternion.Slerp(transform.rotation, target, speed * Time.deltaTime);
		} else {
			transform.position = sidePos;//Vector3.Lerp (topPos, sidePos, speed * Time.deltaTime);
			Quaternion target = Quaternion.LookRotation(new Vector3(0,0,0));
			transform.rotation = Quaternion.Slerp(transform.rotation, target, speed * Time.deltaTime);
		}*/
	}

	void toggleCameraPos() {
		if (isOnTop) {
			isOnTop = false;
			animation.Play("CameraMoveSide", PlayMode.StopAll);
		} else {
			isOnTop = true;
			animation.Play("CameraMoveTop", PlayMode.StopAll);
		}


	}
}
