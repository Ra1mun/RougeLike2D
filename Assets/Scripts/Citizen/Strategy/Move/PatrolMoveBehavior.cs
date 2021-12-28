using UnityEngine;

public class PatrolMoveBehavior: IMovable
{
    private Transform _transform;
    private Vector3[] _endPoints;

    public PatrolMoveBehavior(Transform transform, Vector3[] endPoints)
    {
        _transform = transform;
        _endPoints = endPoints;
    }

    public void Move()
    {
        
    }
}