using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] coins;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoins", 1.0f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCoins()
    {
        Instantiate(coins[Random.Range(0, 0)], spawnPoints[Random.Range(0, 5)].position, Quaternion.identity);

    }
}
