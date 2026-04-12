using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenController : MonoBehaviour
{
    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
