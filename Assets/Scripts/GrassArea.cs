using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrassArea : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider;

    private void OnTriggerEnter2D()
    {
        List<Collider2D>  overlapping = new();
        boxCollider.Overlap(overlapping);

        foreach (var col in overlapping)
        {
            if (col.tag == "Player")
            {
                col.GetComponent<CarController>().MaxDriveSpeed = 2;
            }
        }
    }

    private void OnTriggerExit2D()
    {
        List<Collider2D> overlapping = new();
        boxCollider.Overlap(overlapping);

        if (!overlapping.Any((collider) => collider.tag == "Player"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>().MaxDriveSpeed = 15;
        }
    }

}
