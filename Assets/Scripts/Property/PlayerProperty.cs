using UnityEngine;

[CreateAssetMenu(fileName = "PlayerProperty", menuName = "Settings/PlayerProperty", order = 3)]
public class PlayerProperty : ScriptableObject
{
    [SerializeField] private float _speed;
    [SerializeField] private int _maxhealth;

    public float Speed => _speed;
    public int MaxHealth => _maxhealth;
}