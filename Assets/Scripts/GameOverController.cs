using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void OnRetryCLick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
