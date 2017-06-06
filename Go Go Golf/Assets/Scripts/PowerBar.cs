using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBar : MonoBehaviour {

	private float Z;
	public float ZScale = 1; 
	private Vector2 R;
	private GameObject ball;
	public float maxZimum;

	void Start () 
	{
		


	}

	// Update is called once per frame
	void Update () {

		ball = GameObject.FindGameObjectWithTag ("Ball");

		float resultMagnitude = R.magnitude;

		R = ball.GetComponent<Ball> ().result;
		Z = Mathf.Clamp (0, maxZimum, (resultMagnitude * ZScale));

		//Z = resultMagnitude * ZScale;

		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<Renderer>().enabled = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			GetComponent<Renderer>().enabled = false;
		}

		transform.localScale = new Vector3 (1, 1, Z);

	}
}
