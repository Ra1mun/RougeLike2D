using UnityEngine;

public class FreeMoveBehavior: IMovable
{
    private Transform _transform;
    private Vector3[] _pointVariants;

    public FreeMoveBehavior(Transform transform, Vector3[] pointVariants)
    {
        _transform = transform;
        _pointVariants = pointVariants;
    }

    public void Move()
    {
        
    }
}
