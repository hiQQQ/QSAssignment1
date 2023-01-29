using UnityEngine;

public class Credits : MonoBehaviour
{
    
    public void Quit()
    {
	Debug.Log("Exit");
	UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
