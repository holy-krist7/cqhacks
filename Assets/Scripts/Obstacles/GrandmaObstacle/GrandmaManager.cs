using UnityEngine;

public class GrandmaManager : MonoBehaviour
{
    public GameObject grandma;
    public float minSpawnTime = 3f;
    public float maxSpawnTime = 5f;

    private float spawnX = 0;
    private float currentSpawnTime;
    private float timer = 0;

    // create random spawn position
    void Start()
    {
        spawnX = Random.Range(-2.5f, 2.5f);
        currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // spawn another grandma once timer runs out and set a new time
        if (timer >= currentSpawnTime)
        {
            spawnGrandma();
            timer = 0;

            currentSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void spawnGrandma()
    {
        spawnX = Random.Range(-2.5f, 2.5f);

        GameObject newGrandma = Instantiate(grandma, new Vector3(spawnX, transform.position.y, 0), transform.rotation);

        Grandma grandmaScript = newGrandma.GetComponent<Grandma>();

        if (spawnX <= 0f)
        {
            grandmaScript.SetDirection(1f);
        }
        else
        {
            grandmaScript.SetDirection(-1f);
        }
    }
}
