using Unity.VisualScripting;
using UnityEngine;

public class CopCarManager : MonoBehaviour
{
    public float minSpawnInterval;
    public float spawnIntervalRange;

    [SerializeField] private GameObject enemyCar;

    private float spawnIntervalTimer;
    private float spawnInteralWaitTime = 20;

    private void Update()
    {
        spawnIntervalTimer += Time.deltaTime;

        if (spawnIntervalTimer > spawnInteralWaitTime)
        {
            spawnIntervalTimer = 0;
            spawnInteralWaitTime = Random.Range(minSpawnInterval, minSpawnInterval + spawnIntervalRange);

            Instantiate(enemyCar, new Vector2(0, 10), Quaternion.identity);
        }
    }
}
