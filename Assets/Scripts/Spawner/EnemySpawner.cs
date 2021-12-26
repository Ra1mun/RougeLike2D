using System;
using UnityEngine;

[RequireComponent(typeof(EnemyFactory))]
public class EnemySpawner  : MonoBehaviour
{
    [SerializeField] private EnemyFactory _enemyFactory;
    [SerializeField] private Vector3 _spawnPosition;

    public event Action<Enemy> OnEnemySpawned;

    private void Awake()
    {
        Spawn();
    }

    private void Spawn()
    {
        var enemy = _enemyFactory.Spawn(_spawnPosition, Quaternion.identity);

        OnEnemySpawned?.Invoke(enemy);
    }
}