using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public GameObject[] projectile = new GameObject[3];
    public float minSpawnTime = 2f;
    public float maxSpawnTime = 4f;


    private float currentSpawnTime;
    private float timer = 0;
    private float yPosition = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentSpawnTime)
        {
            spawnProjectile();
            timer = 0;

            currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void spawnProjectile()
    {
        yPosition = Random.Range(0, 4);
        int index = Random.Range(0, projectile.Length);

        Instantiate(projectile[index], new Vector3(transform.position.x, yPosition, 0), transform.rotation);
    }
}
