using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public static int playerHP = 3;

    // Update is called once per frame
    void Update()
    {
        if(playerHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
