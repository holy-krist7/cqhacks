using UnityEngine;

public class CarSpriteChange : MonoBehaviour
{
    public Sprite blackCar;

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // change the car sprite into a black car
    public void SetBlack()
    {
        sr.sprite = blackCar;
    }
}
