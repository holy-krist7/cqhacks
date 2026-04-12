using UnityEngine;

public class TrackMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;

    // Update is called once per frame
    void Update()
    {
        // move the track down
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;

        // destroy object off screen
        if (transform.position.y < deadZone)
        {
            Debug.Log("Track Deleted");
            Destroy(gameObject);
        }
    }
}
