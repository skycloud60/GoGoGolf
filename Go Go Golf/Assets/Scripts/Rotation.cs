using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public Transform lookat;
	public Transform camTransform;
	public GameObject cameraStart;

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 60.0f;
	//public Camera cam;

	private float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 4.0f;
	private float sensitivityY = 4.0f;

	private Quaternion rotation = Quaternion.identity;
	private Vector3 dir;

	private void Start(){

		//camTransform = transform;
		//cam = Camera.main;
		CalculateCamera();
		MoveCamera ();
	}

	private void Update () {
		
		if (Input.GetButton ("Fire2")) {
			CalculateCamera ();
		}
	}

	private void LateUpdate (){

		camTransform.position = lookat.position + rotation * dir;
		camTransform.LookAt (lookat.position);

	}

	void OnMouseUp()
	{
		rotation = Quaternion.identity;
	}

	private void CalculateCamera()
	{
		currentX = Input.GetAxis ("Mouse X")*sensitivityX;
		//currentY = Input.GetAxis ("Mouse Y")*sensitivityY;
		currentY = 0.0f;

		///// COME BACK TO THIS _ TALK TO SHANE ABOUT POTENTIAL FIX ////

		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);


		dir = transform.forward * -distance;
		rotation = Quaternion.Euler (currentY, currentX, 0);
	}

	public void MoveCamera ()
	{
		transform.position = cameraStart.transform.position;
		transform.localRotation = cameraStart.transform.localRotation;
	}

}
