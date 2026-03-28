using UnityEngine;

[CreateAssetMenu(fileName = "CarManagerLapValues", menuName = "Scriptable Objects/CarManagerLapValues")]
public class CarManagerLapValues : ScriptableObject
{
    public float minSpawnWait;
    public float spawnWaitRange;
    public GameObject prefab;
}
