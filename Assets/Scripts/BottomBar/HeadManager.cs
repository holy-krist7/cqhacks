using UnityEngine;

public class HeadManager : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite damagedSprite1;
    public Sprite damagedSprite2;
    public Sprite damagedSprite3;

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
        // switch the sprite based on player hp
        switch (player.playerHP)
        {
            case 3:
                sr.sprite = defaultSprite;
                break;
            case 2:
                sr.sprite = damagedSprite1;
                break;
            case 1:
                sr.sprite = damagedSprite2;
                break;
            default:
                sr.sprite= damagedSprite3;
                break;
        }   
    }
}
