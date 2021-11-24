using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesRandom : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefabs;
    public int[] spikes = new int[16];
    public int[] test = new int[25];

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 16; x++)
        {
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            if (test[randSpawnPoint] == 1)
            {
                x--;
            }
            else
            {
                spikes[x] = randSpawnPoint;
                Generate(spikes[x]);
                test[randSpawnPoint] = 1;
            }
        }
    }

    void Generate(int randSpawnPoint)
    {

        Instantiate(enemyPrefabs, spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}