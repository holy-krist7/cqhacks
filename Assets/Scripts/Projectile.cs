using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed = 5;
    public float shootSpeed = 8;
    public float deadZone = -12;
    public float rotationSpeed = 360f;

    private float stopX = 0f;
    private bool isShot = true;

    private Vector3 moveDirection;

    void Start()
    {
        stopX = Random.Range(-2.5f, 2.5f);

        float randomY = Random.Range(-0.5f, 0.5f);
        moveDirection = new Vector3(-1f, randomY, 0f).normalized;
    }

    void Update()
    {
        if (isShot)
        {
            transform.position += moveDirection * shootSpeed * Time.deltaTime;

            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

            if (transform.position.x <= stopX)
            {
                isShot = false;
            }
        }
        else
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Projectile Destroyed");
        }
    }
}
