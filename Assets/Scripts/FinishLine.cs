using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // increase lap
            Debug.Log("next lap");
            Destroy(GetComponent<BoxCollider2D>());
        }
    }
}
