using UnityEngine;

public class EnemyCarAi : CarAI
{
    public float randomXRange = 7.5f;
    public float chaseSpeed = 20;
    public float chaseAccel = 500;

    private void Start()
    {
        Phase1();
    }

    void Phase1()
    {
        var randomX = Random.Range(-randomXRange, randomXRange);
        var randomPoint = new Vector2(randomX, -4);
        currentTargetPosition = randomPoint;

        carController.DriveAccel = 100;

        Invoke("Phase2", 2);
    }


    void Phase2()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        carController.MaxDriveSpeed = chaseSpeed;
        carController.DriveAccel = chaseAccel;

        Invoke("Phase3", 6);
    }


    void Phase3()
    {
        targetPlayer = null;
        currentTargetPosition = new Vector2(transform.position.x, -100);

        carController.MaxDriveSpeed = 6;

        Destroy(gameObject, 5);
    }

}
