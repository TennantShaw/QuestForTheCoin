using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables
    public GameObject enemyPrefab;
    private float rangeX = 200.0f;
    private float botRangeZ = 200.0f;
    private float topRangeZ = 600.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateRandomRange(), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateRandomRange () {
        float randomRangeX = Random.Range(-rangeX, rangeX);
        float randomRangeZ = Random.Range(-botRangeZ, topRangeZ);
        Vector3 spawnRange = new Vector3(randomRangeX, 0.0f, randomRangeZ);
        return spawnRange;
    }
}
