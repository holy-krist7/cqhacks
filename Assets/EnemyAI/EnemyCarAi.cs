using UnityEngine;

public class EnemyCarAi : CarAI
{
    private void Start()
    {
        Phase1();
    }

    void Phase1()
    {
        var randomX = Random.Range(-7.5f, 7.5f);
        var randomPoint = new Vector2(randomX, -3);
        currentTargetPosition = randomPoint;

        carController.DriveAccel = 100;

        Invoke("Phase2", Random.Range(4f, 6));
    }


    void Phase2()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        carController.MaxDriveSpeed = 3;
        carController.DriveAccel = 10;

        Invoke("Phase3", 8);
    }


    void Phase3()
    {
        targetPlayer = null;
        currentTargetPosition = new Vector2(transform.position.x, -9);

        carController.MaxDriveSpeed = 6;

        Destroy(gameObject, 5);
    }

}
