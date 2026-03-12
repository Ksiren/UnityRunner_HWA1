using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private ObstacleData data;
    private Transform player;

    [SerializeField] double speeder;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.Translate(Vector3.back * data.moveSpeed * Time.deltaTime);
        if (transform.position.z < player.position.z - 12)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.gameObject.GetComponent<PlayerHealth>();
        
        health.TakeDamage(data.damage);
        Destroy(gameObject);

    }
}