using UnityEngine;

public class PlayerPropertyIniter : MonoBehaviour
{
    private Player _player;
    [SerializeField] private UnitProperty _playerProperty;

    public void Init(Player player)
    {
        player.Init(
            _playerProperty.MaxHealth,
            _playerProperty.Speed);
    }
}