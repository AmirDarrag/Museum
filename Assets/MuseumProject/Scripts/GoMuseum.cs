using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoMuseum : MonoBehaviour {


	public void ResetScene() 
	{
		// Reset the scene when the user clicks the sign post
		SceneManager.LoadScene("Museum");
	}
}
