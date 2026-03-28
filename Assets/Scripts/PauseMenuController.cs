using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public void OnResumeClick()
    {
        // resume game
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
