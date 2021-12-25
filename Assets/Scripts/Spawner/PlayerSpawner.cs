using System;
using UnityEngine;

[RequireComponent(typeof(PlayerFactory))]
public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private PlayerFactory _playerFactory;
    [SerializeField] private Vector3 _spawnPosition;

    public event Action<Player> OnPlayerSpawned;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        var player = _playerFactory.Spawn(_spawnPosition, Quaternion.identity);

        OnPlayerSpawned?.Invoke(player);
    }
}