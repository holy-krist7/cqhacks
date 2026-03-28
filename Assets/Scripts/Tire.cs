using UnityEngine;

public class Tire : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;


    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;

        if (transform.position.y < deadZone)
        {
            Debug.Log("Tire Deleted");
            Destroy(gameObject);
        }
    }
}
