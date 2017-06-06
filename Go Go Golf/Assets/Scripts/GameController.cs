using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public GameObject mainCamera;
	private GameObject s;

	void Start ()
	{
		mainCamera.GetComponent<Rotation> ().MoveCamera ();
		s = GameObject.FindGameObjectWithTag ("Strokes");
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			s.GetComponent<Strokes> ().strokes++;
		}
	}


}