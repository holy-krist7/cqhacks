using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenController : MonoBehaviour
{
    // switch to main menu
    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
