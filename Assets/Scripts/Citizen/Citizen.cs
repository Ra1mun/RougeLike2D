using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Citizen : MonoBehaviour
{
    protected ITradable _tradable;
    protected IMovable _movable;
    protected ISpeakable _speakable;
    [SerializeField] protected NPCProperty _property;

    protected abstract void InitBehaviours();

    public void Trade(Player player)
    {
        _tradable.Trade(player);
    }

    public void Speak()
    {
        _speakable.Speak();
    }

    public void Move()
    {

    }
}
