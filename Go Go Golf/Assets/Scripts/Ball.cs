﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float forceScaleFactor = 100;

	private Vector3 firstClick;
	private Vector3 secondClick;

	void Start () 
	{

	}
		

	void OnMouseDown() 
	{
		firstClick = Input.mousePosition;
	}

	/*{
		mMouseDownPos = Input.mousePosition;
		GetComponent<Rigidbody> ().AddForce (Vector3.right * speed, ForceMode.Impulse);
		mMouseDownPos = Input.mousePosition;
		Debug.Log( "the mouse down pos is " + mMouseDownPos.z.ToString() );
		mMouseDownPos.z = 0;
	}
*/


	void OnMouseUp() {
		secondClick = Input.mousePosition;

		GetComponent<Rigidbody> ().AddForce((firstClick - secondClick) * forceScaleFactor, ForceMode.Impulse);
	}

}

	/*{
		mMouseUpPos = Input.mousePosition;
		mMouseUpPos = Input.mousePosition;
		mMouseUpPos.z = 0;
		var direction = mMouseDownPos - mMouseUpPos;
		direction.Normalize();
		GetComponent<Rigidbody> ().AddForce (direction * speed);
		Debug.Log( "the mouse up pos is " + mMouseUpPos.ToString() );
	} 
	*/
