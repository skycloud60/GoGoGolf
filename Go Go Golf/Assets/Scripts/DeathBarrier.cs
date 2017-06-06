using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour {
	private GameObject s;

	void Start () 
	{
		s = GameObject.FindGameObjectWithTag ("Strokes");
	}


	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Ball")
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			s.GetComponent<Strokes> ().strokes++;
		}

	}
}
 