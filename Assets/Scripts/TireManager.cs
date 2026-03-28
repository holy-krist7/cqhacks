using Unity.VisualScripting;
using UnityEngine;

public class TireManager : MonoBehaviour
{
    public GameObject tire;
    public float minSpawnTime = 3f;
    public float maxSpawnTime = 5f;

    private float spawnX = 0f;
    private float currentSpawnTime;
    private float timer = 0;

    private void Start()
    {
        spawnX = Random.Range(-2.5f, 2.5f);
        currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentSpawnTime)
        {
            SpawnTire();
            timer = 0;

            currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnTire()
    {
        spawnX = Random.Range(-2.5f, 2.5f);
        Instantiate(tire, new Vector3(spawnX, transform.position.y, 0), transform.rotation);
    }
}
