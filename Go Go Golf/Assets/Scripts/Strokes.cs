using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strokes : MonoBehaviour {

	public GUIText scoreText;
	[HideInInspector]
	public int strokes;

	// Use this for initialization
	void Start () {
		strokes = 0;
	}


	void Update ()
	{
		UpdateScore ();
	}


	void UpdateScore ()
	{
		scoreText.text = "Strokes: " + strokes;
	}
		

}
