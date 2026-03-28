using UnityEngine;
using UnityEngine.SceneManagement;

public class Grandma : MonoBehaviour
{
    public float xMoveSpeed = 5;
    public float yMoveSpeed = 5;
    public float deadZone = -12;

    private float xDirection = -1f;
    private SpriteRenderer sr;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetDirection(float direction)
    {
        xDirection = direction;

        if (sr != null)
        {
            sr.flipX = direction < 0 ? false : true;
        }
    }

    private void Start()
    {
        xMoveSpeed = Random.Range(2, 4);
    }

    void Update()
    {
        Vector3 movement = new Vector3(xDirection * xMoveSpeed, -yMoveSpeed, 0f);
        transform.position += movement * Time.deltaTime;

        if (transform.position.y < deadZone)
        {
            Debug.Log("Grandma Deleted");
            Destroy(gameObject);
        }
    }
}
