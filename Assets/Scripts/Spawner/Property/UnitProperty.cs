using UnityEngine;

[CreateAssetMenu(fileName = "UnitProperty", menuName = "Settings/UnitProperty", order = 1)]
public class UnitProperty : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _speed;

    public int MaxHealth => _maxHealth;
    public float Speed => _speed;
}