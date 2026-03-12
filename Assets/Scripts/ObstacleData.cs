using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HWA1_Runner/Obstacle Data")]
public class ObstacleData : ScriptableObject
{
    [SerializeField] public float damage = 50;
    [SerializeField] public float moveSpeed = 10;
    [SerializeField] public float speedIncreaseRate = 0.1f;

}