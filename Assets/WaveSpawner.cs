using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public float timeBetweenWaves = 5f;
    public float cd = 2f;

    private int waveIndex = 0;

    public Transform spawnPoint;

    void Update()
    {
        if (cd <= 0f)
        {
            StartCoroutine(SpawnWave());
            cd = timeBetweenWaves;
        }

        cd -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {

        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
