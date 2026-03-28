using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public static int playerHP;

    // Update is called once per frame
    void Update()
    {
        if(playerHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
