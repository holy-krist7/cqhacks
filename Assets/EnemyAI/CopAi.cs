using UnityEngine;

public class CopAi : CarAI
{

    [SerializeField] GameObject oilPrefab;

    private float startTimer;
    private float startWaitTime = 2;

    private float spillTimer;
    private float spillWaitTime = 2;

    private int swayCount;
    private int phase;


    private void Start()
    {
        currentTargetPosition = new(Random.Range(-.1f, .1f), 4);
    }

    override protected void Update()
    {
        base.Update();

        switch (phase)
        {
            case 0:
                startTimer += Time.deltaTime;
                if (startTimer > startWaitTime)
                {
                    drivePGain = 1;
                    phase++;
                }
                break; 

            case 1:
                Phase1();
                break;

            case 2:
                currentTargetPosition = transform.position + Vector3.up * 10;
                phase++;
                break;
        }
    }

    void Phase1()
    {
        startTimer += Time.deltaTime;
        spillTimer += Time.deltaTime;

        if (swayCount == 10)
        {
            phase++;
            return;
        }

        if (Vector2.Distance(transform.position, currentTargetPosition) < .75)
        {
            startTimer = 0;
            swayCount++;

            currentTargetPosition = new(transform.position.x > 0? -7: 7, 4);
        }

        if (spillTimer > spillWaitTime)
        {
            spillTimer = 0;
            spillWaitTime = Random.Range(.5f, 1f);
            Instantiate(oilPrefab, transform.position, Quaternion.identity);
        }
    }

}
