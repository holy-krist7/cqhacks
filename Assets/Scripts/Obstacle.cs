using Unity.Multiplayer.PlayMode;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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

    private void Update()
    {
        if (player.isCooldown == true)
        {
            player.timer += Time.deltaTime;

            if (player.timer >= player.cooldownTime)
            {
                player.isCooldown = false;
                Debug.Log("Player is out of cooldown");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player.isCooldown == false)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                Debug.Log("obstacle hit the player");

                player.playerHP--;
                SpriteShake head = GameObject.FindGameObjectWithTag("HeadSprite").GetComponent<SpriteShake>();
                head.Shake(.2f, 60);

                player.isCooldown = true;
                Debug.Log("Player is in cooldown");

                if (player.playerHP <= 0)
                {
                    //Time.timeScale = 0f;
                   // StartCoroutine(TimerRoutine(1f));
                    if (isTimerRunning == false)
                    {
                        SceneManager.LoadScene("GameOver");
                    }
                }
            }
        }
    }

    IEnumerator TimerRoutine(float duration)
    {
        isTimerRunning = true;
        Debug.Log("Timer Started");

        yield return new WaitForSeconds(duration);

        Debug.Log("Timer Finished!");
        isTimerRunning = false;
    }
}
