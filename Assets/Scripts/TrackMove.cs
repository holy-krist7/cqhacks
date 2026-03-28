using UnityEngine;

public class TrackMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;

        if (transform.position.y < deadZone)
        {
            Debug.Log("Track Deleted");
            Destroy(gameObject);
        }
    }
}
