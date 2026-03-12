using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private float spawnDistance = 30;
    [SerializeField] private float spawnInterval = 2;
    [SerializeField] private float laneOffset = 3;

    private float timer;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    private void SpawnObstacle()
    {
        int lane = Random.Range(-1, 2);
        int index = Random.Range(0, obstaclePrefabs.Length);

        Vector3 spawnPos = new Vector3( lane * laneOffset, 0.5f, player.position.z + spawnDistance);

        Instantiate(obstaclePrefabs[index], spawnPos, Quaternion.identity);
    }
}