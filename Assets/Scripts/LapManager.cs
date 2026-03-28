using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public CopCarManager CopCarManager;
    public List<CarManagerLapValues> copValues;

    public EnemyCarManager EnemyCarManager;
    public List<CarManagerLapValues> enemyCarValues;


    public int CurrentLap;

    private void Start()
    {
        CopCarManager.Change(copValues[CurrentLap]);
        EnemyCarManager.Change(copValues[CurrentLap]);
    }

    public void OnLap()
    {
        CurrentLap++;
        CopCarManager.Change(copValues[CurrentLap]);
        EnemyCarManager.Change(copValues[CurrentLap]);

    }
}
