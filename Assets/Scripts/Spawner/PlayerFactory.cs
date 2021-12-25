using System.Collections.Generic;
using Assets.Scripts.Player;
using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField] private PlayerPropertyIniter _playerPropertyIniter;
    [SerializeField] private List<Player> _players;

    public Player Spawn()
    {
        var player = Instantiate(_players.RandomItem());
        _playerPropertyIniter.Init(player);

        return player;
    }

    public Player Spawn(Vector3 position, Quaternion quaternion)
    {
        var player = Instantiate(_players.RandomItem(), position, quaternion);
        _playerPropertyIniter.Init(player);

        return player;
    }
}