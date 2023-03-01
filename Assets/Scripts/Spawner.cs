using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabASpawnear;
    public float minX = 10f;
    public float maxX = 15f;
    public float yPos = -3.31f;
    public float intervaloMinTiempoSpawn = 3f;
    public float intervaloMaxTiempoSpawn = 6f;

    private void Start()
    {
        StartCoroutine(SpawnObstaculo(Random.Range(intervaloMinTiempoSpawn, intervaloMaxTiempoSpawn), prefabASpawnear));
    }

    private IEnumerator SpawnObstaculo(float intervalo, GameObject obstaculo)
    {
        
        yield return new WaitForSeconds(intervalo);
        Instantiate(obstaculo, new Vector3(Random.Range(minX,maxX), yPos, 0), Quaternion.identity);
        StartCoroutine(SpawnObstaculo(intervalo, obstaculo));
    }
}
