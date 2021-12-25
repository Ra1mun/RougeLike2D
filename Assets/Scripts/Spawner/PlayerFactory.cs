using Assets.Scripts.Player;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField] private List<Player> _players;
    [SerializeField] private PlayerPropertyIniter _playerPropertyIniter;
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
