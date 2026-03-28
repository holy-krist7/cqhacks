using UnityEngine;

public class CarAI : MonoBehaviour
{
    [SerializeField] protected CarController carController;
    [SerializeField] protected float drivePGain;
    protected Transform targetPlayer;
    protected Vector2 currentTargetPosition;

     virtual protected void Update()
    {
        if (targetPlayer)
        {
            currentTargetPosition = targetPlayer.position;
        }

        MoveToTarget();
    }

    private void MoveToTarget()
    {
        var vectorToTarget = (Vector3)currentTargetPosition - transform.position;
        var distanceToTarget = Vector3.Magnitude(vectorToTarget);

        if (distanceToTarget > 0.1)
        {
            carController.SetDriveDirection(vectorToTarget * drivePGain);
        }
        else
        {
            carController.SetDriveDirection(Vector2.zero);
        }

    }


}
