using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speedX;
	public float speedY;
	public float speedZ;
	private CameraMove vars;

	public GameObject kamera;

	// Use this for initialization
	void Start () {
		vars = kamera.GetComponent<CameraMove> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (vars.isOnTop) {
			float vertMov = -(Input.GetAxis ("Vertical") * speedZ * Time.deltaTime);
			float horizonMov = Input.GetAxis("Horizontal") * speedX * Time.deltaTime;
			transform.position = new Vector3(transform.position.x + vertMov, transform.position.y, transform.position.z + horizonMov);
		} else {
			float vertMov = Input.GetAxis ("Vertical") * speedY * Time.deltaTime;
			float horizonMov = -(Input.GetAxis("Horizontal") * speedX * Time.deltaTime);
			transform.position = new Vector3(transform.position.x + horizonMov, transform.position.y + vertMov, transform.position.z);
		}
	}
}
