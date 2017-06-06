using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAdvancement : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (SceneManager.GetActiveScene ().buildIndex - 1 == SceneManager.sceneCountInBuildSettings) 
		{
			SceneManager.LoadScene (0);
		} 
		else 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}		
	}

}
