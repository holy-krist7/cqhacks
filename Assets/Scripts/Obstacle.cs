using Unity.Multiplayer.PlayMode;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class Obstacle : MonoBehaviour
{

    private GameObject car;
    private Player player;

    private bool isTimerRunning = false;

    private void Start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
        player = car.GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player.isCooldown == false)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log("obstacle hit the player");

                player.playerHP--;

                SpriteShake head = GameObject.FindGameObjectWithTag("HeadSprite").GetComponent<SpriteShake>();
                head.Shake(.2f, 60);

                player.isCooldown = true;
                player.StartFlash();
                Debug.Log("Player is in cooldown");

                if (player.playerHP <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
}
