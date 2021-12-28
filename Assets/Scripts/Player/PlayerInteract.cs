using System;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public event Action<Citizen> OnInteracted; 

    private void Update()
    {
        Interact();
    }

    private void Interact()
    {
        var objects = Physics2D.OverlapAreaAll(transform.position, Vector2.right);

        foreach (var nearby in objects)
        {
            if (nearby != null)
            {
                if (nearby.TryGetComponent<Citizen>(out var citizen))
                {
                    OnInteracted?.Invoke(citizen);
                }
            }
        }
    }
}