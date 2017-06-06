using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float forceScaleFactor = 100;

	private Vector2 firstClick;
	private Vector2 secondClick;
	[HideInInspector]
	public Vector2 result;
	private GameObject cam;
	private GameObject s;
	private Rigidbody rb;

	void Start () 
	{
		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		s = GameObject.FindGameObjectWithTag ("Strokes");
		rb = GetComponent<Rigidbody>();
	}
		

	void OnMouseDown() 
	{
		firstClick = Input.mousePosition;
	}
		

	void OnMouseUp()
	{
		secondClick = Input.mousePosition;

		result = firstClick - secondClick;
		float resultLength = result.magnitude;
		float resultForce = resultLength * forceScaleFactor;

		Vector3 newVec = Vector3.Normalize (Vector3.ProjectOnPlane (cam.transform.up, Vector3.up));

		GetComponent<Rigidbody> ().AddForce(newVec * resultForce, ForceMode.Impulse);
		//GetComponent<Rigidbody> ().AddTorque()

		s.GetComponent<Strokes> ().strokes++;
	}

	void Update()
	{
		if (rb.velocity.magnitude < 0.5) 
		{
			rb.velocity = Vector3.zero;
		}

		if (rb.angularVelocity.magnitude < 1) 
		{
			rb.angularVelocity = Vector3.zero;
		}
			
	}

}