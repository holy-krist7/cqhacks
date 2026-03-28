using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public GameObject track;
    public float spawnRate = 5;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTrack();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTrack();
            timer = 0;
        }
    }

    void spawnTrack()
    {
        Instantiate(track, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
