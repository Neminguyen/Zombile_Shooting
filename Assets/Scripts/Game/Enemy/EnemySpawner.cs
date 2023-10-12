using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    public float spawnInterval = 3f;

    private float spawnRangeX = 41.5f;
    private float spawnRangeY = 25.2f;

    private float timeSinceLastSpawn = 0f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }

    private void SpawnEnemy()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosY = Random.Range(-spawnRangeY, spawnRangeY);
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, 0f);

        Instantiate(_enemyPrefab, spawnPos, Quaternion.identity);
    }

    //[SerializeField] private float _minimumSpawnTime;

    //[SerializeField] private float _maximumSpawTime;

    //private float _timeUntilSpawn;

    //// Start is called before the first frame update
    //void Awake()
    //{
    //    SetTimeUntilSpawn();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    _timeUntilSpawn -= Time.deltaTime;

    //    if (_timeUntilSpawn <= 0)
    //    {
    //        Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    //        SetTimeUntilSpawn();
    //    }

    //}

    //private void SetTimeUntilSpawn()
    //{
    //    _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawTime);

    //}
}
