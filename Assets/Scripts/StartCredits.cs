using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCredits : MonoBehaviour
{
    
    public void LoadCredits()
    {
        SceneManager.LoadScene("Outro");
    }
}
