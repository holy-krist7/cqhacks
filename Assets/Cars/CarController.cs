using System.Transactions;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour

{
    public float MaxDriveSpeed = 15;
    public float DriveAccel = 100;
    [SerializeField] protected float angleRange = 30;

    [SerializeField] protected InputActionReference moveAction;
    [SerializeField] protected Rigidbody2D rb;

    private Vector2 driveDirectionInput;

    protected float currentAngle = 90f;

    private void Update()
    {
        // if moveAction assigned, react to input
        if (moveAction)
        {
            SetDriveDirection(moveAction.action.ReadValue<Vector2>());
        }

        rb.linearVelocity = Vector2.MoveTowards(rb.linearVelocity, driveDirectionInput * MaxDriveSpeed, DriveAccel * Time.deltaTime);

        // handle angle
        var targetAngle = -Vector2.Dot(rb.linearVelocity, Vector2.right) / MaxDriveSpeed * angleRange;
        currentAngle = Mathf.MoveTowards(currentAngle, targetAngle, 360 * Time.deltaTime);
        transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);
    }

    public void SetDriveDirection(Vector2 direction)
    {
        driveDirectionInput = Vector2.ClampMagnitude(direction, 1f);
    }
}
