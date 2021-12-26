using UnityEngine;

public class PlayerPropertyIniter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private UnitProperty _playerProperty;

    private void Awake()
    {
        _player.Init(
            _playerProperty.MaxHealth,
            _playerProperty.Speed);
    }
}