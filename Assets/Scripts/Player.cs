using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerHP = 3;

    public float cooldownTime = 2f;
    public float timer = 0;
    public bool isCooldown = false;

    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();   
    }

    private void Update()
    {
        if (isCooldown)
        {
            timer += Time.deltaTime;

            if (timer >= cooldownTime)
            {
                isCooldown = false;
                timer = 0f;
                Debug.Log("Player is out of cooldown");
            }
        }
    }

    public IEnumerator FlashSprite()
    {
        while (isCooldown)
        {
            sr.enabled = false;
            yield return new WaitForSeconds(0.1f);

            sr.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }

        sr.enabled = true;
    }

    public void StartFlash()
    {
        StartCoroutine(FlashSprite());
    }
}
