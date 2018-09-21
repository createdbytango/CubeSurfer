using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool HasGameEnded = false;
	public float restartDelay= 0.7f;

	public void EndGame()
	{
		if(HasGameEnded==false)
		{
			HasGameEnded=true;
			Invoke("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
