using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefabs;

    public float timer;
    public float waitingTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //timer
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            Generate();
            timer = 0;
        }
    }

    void Generate()
    {
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs, spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}