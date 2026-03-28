using System.Collections.Generic;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapManager : MonoBehaviour
{
    public CopCarManager CopCarManager;
    public List<CarManagerLapValues> copValues;

    public EnemyCarManager EnemyCarManager;
    public List<CarManagerLapValues> enemyCarValues;

    public CustomFontParser text;
    public GameObject finishLine;

    private float lapTimer;
    private float lapWaitTimer = 15;


    public int CurrentLap;

    private void Start()
    {
        CopCarManager.Change(copValues[CurrentLap]);
        EnemyCarManager.Change(enemyCarValues[CurrentLap]);
    }

    private void Update()
    {
        lapTimer += Time.deltaTime;
        if (lapTimer > lapWaitTimer)
        {
            Instantiate(finishLine, new Vector2(0, 10), Quaternion.identity);
            lapTimer = 0;
        }
    }

    public void OnLap()
    {
        CurrentLap++;

        if (CurrentLap >= 3)
        {
            SceneManager.LoadScene("WinScene");
            return;
        }

        CopCarManager.Change(copValues[CurrentLap]);
        EnemyCarManager.Change(enemyCarValues[CurrentLap]);
        text.SetText("LAP " + (CurrentLap + 1));

    }
}
