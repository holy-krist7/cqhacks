using UnityEngine;

public class TrackObject : MonoBehaviour
{
    protected TrackComponent Track;
    void Start()
    {
        if (Track == null)
        {
            Track = GameObject.FindWithTag("Track")?.GetComponent<TrackComponent>();
        }

    }

    private void Update()
    {
        if (Track)
        {
            transform.position += (Vector3)Track.TrackVelocity * Time.deltaTime;
        }

        if (transform.position.magnitude > 300)
        {
            Destroy(gameObject);
        }
    }
}
