using UnityEngine;

public class CarSpriteChange : MonoBehaviour
{
    public Sprite blackCar;

    private GameObject car;
    private Player player;

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
        player = car.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.playerHP <= 0)
        {
            sr.sprite = blackCar;
        }
    }
}
