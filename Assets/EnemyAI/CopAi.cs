using UnityEngine;

public class CopAi : CarAI
{

    [SerializeField] GameObject oilPrefab;

    [SerializeField] private float targetYValue = 20;
    [SerializeField] private float targetXRange = 60;

    [SerializeField] private float minSpillWaitTime;
    [SerializeField] private float spillWaitTimeRange;

    private float startTimer;
    private float startWaitTime = 2;

    private float spillTimer;
    private float spillWaitTime = 2;

    private int swayCount;
    private int phase;


    private void Start()
    {
        currentTargetPosition = new(Random.Range(-.1f, .1f), targetYValue);
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
                SwayPhase();
                break;

            case 2:
                currentTargetPosition = new(transform.position.x, 100);
                phase++;
                Destroy(gameObject, 10);
                break;
        }
    }

    void SwayPhase()
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

            currentTargetPosition = new(transform.position.x > 0? -targetXRange: targetXRange, targetYValue);
        }

        if (spillTimer > spillWaitTime)
        {
            spillTimer = 0;
            spillWaitTime = Random.Range(minSpillWaitTime, minSpillWaitTime + spillWaitTimeRange);
            Instantiate(oilPrefab, transform.position, Quaternion.identity);
        }
    }

}
