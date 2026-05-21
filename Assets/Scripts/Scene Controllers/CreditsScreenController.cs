using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScreenController : MonoBehaviour
{
    public void OnExitClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
