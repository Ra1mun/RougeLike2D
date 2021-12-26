using System.Collections.Generic;
using Assets.Scripts.Player;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private EnemyPropertyIniter _playerPropertyIniter;
    [SerializeField] private Enemy _enemy;

    public Enemy Spawn()
    {
        var enemy = Instantiate(_enemy);
        _playerPropertyIniter.Init(enemy);

        return enemy;
    }

    public Enemy Spawn(Vector3 position, Quaternion quaternion)
    {
        var player = Instantiate(_enemy, position, quaternion);
        _playerPropertyIniter.Init(player);

        return player;
    }
}