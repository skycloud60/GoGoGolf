using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float forceScaleFactor = 100;

	private Vector2 firstClick;
	private Vector2 secondClick;
	private Vector2 result;
	private GameObject cam;
	[HideInInspector]
	private GameObject s;

	void Start () 
	{
		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		s = GameObject.FindGameObjectWithTag ("Strokes");
	}
		

	void OnMouseDown() 
	{
		firstClick = Input.mousePosition;
	}
		

	void OnMouseUp() {
		secondClick = Input.mousePosition;

		result = firstClick - secondClick;
		float resultLength = result.magnitude;
		float resultForce = resultLength * forceScaleFactor;

		Vector3 newVec = Vector3.Normalize (Vector3.ProjectOnPlane (cam.transform.up, Vector3.up));

		GetComponent<Rigidbody> ().AddForce(newVec * resultForce, ForceMode.Impulse);

		s.GetComponent<Strokes> ().strokes++;
	}

}