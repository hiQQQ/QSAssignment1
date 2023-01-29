using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
	if (gameHasEnded == true)
	{
	    
	}
	else {
	    completeLevelUI.SetActive(true);
	    gameHasEnded = true;
	}
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
	{
	    gameHasEnded = true;
	    Debug.Log("Game Over");
	    Invoke("Restart", 3f);
	}
    }

    void Restart()
    {
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
