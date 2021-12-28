using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class ArmoryDealerNPC : Citizen
{
    [SerializeField] private DialogSystem _dialogSystem;
    protected override void InitBehaviours()
    {
        _tradable = new TradeBehavior();
        _speakable = new SimpleDialogBehavior("E", _dialogSystem);
        _movable = new DontMoveBehavior();
    }

    private void Awake()
    {
        InitBehaviours();
    }
}