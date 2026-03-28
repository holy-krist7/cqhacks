using Unity.Multiplayer.PlayMode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private GameObject car;
    private Player player;


    private void Start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
        player = car.GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("obstacle hit the player");

            player.playerHP--;

            if (player.playerHP <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
