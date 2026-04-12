using UnityEngine;

public class CarSpriteChange : MonoBehaviour
{
    public Sprite blackCar;

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetBlack()
    {
        sr.sprite = blackCar;
    }
}
