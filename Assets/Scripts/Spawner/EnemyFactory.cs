using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private EnemyPropertyIniter _enemyPropertyIniter;
    [SerializeField] private Enemy _enemy;

    public Enemy Spawn()
    {
        var enemy = Instantiate(_enemy);
        _enemyPropertyIniter.Init(enemy);

        return enemy;
    }

    public Enemy Spawn(Vector3 position, Quaternion quaternion)
    {
        var player = Instantiate(_enemy, position, quaternion);
        _enemyPropertyIniter.Init(player);

        return player;
    }
}