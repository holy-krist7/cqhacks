using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerHP = 3;

    public float cooldownTime = 10;
    public float timer = 0;
    public bool isCooldown = false;
}
