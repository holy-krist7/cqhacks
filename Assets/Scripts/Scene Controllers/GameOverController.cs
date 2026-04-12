using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // handle retry button for game over screen
    public void OnRetryCLick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
