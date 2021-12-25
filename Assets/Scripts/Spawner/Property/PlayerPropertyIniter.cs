using Assets.Scripts.Input;
using UnityEngine;

public class PlayerPropertyIniter : MonoBehaviour
{
    [SerializeField] private UnitProperty _playerProperty;

    private Player _player;

    public void Init(Player player)
    {
        player.Init(
            _playerProperty.MaxHealth,
            _playerProperty.Speed);
    }
}
