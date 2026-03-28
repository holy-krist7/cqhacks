using UnityEngine;

public class SpriteShake : MonoBehaviour
{
    private Vector2 initPosition;

    public float shakeTimer;
    public float shakeWaitTime;

    public float shakeStrength;
    public float shakeMagnitude;
    public bool isShaking;

    private void Start()
    {
        initPosition = transform.position;
    }

    private void Update()
    {
        shakeTimer += Time.deltaTime; 

        if (isShaking)
        {
            transform.position = initPosition + new Vector2(
                Mathf.Sin(Time.time * shakeStrength) * shakeMagnitude ,
                Mathf.Cos(Time.time * shakeStrength) * shakeMagnitude
            );
        }

        if (shakeTimer > shakeWaitTime)
        {
            isShaking = false;
            transform.position = initPosition;
        }
    }

    public void Shake(float time, float strength)
    {
        shakeTimer = 0;
        shakeWaitTime = time;
        shakeStrength = strength;

        isShaking = true;
    }
}
