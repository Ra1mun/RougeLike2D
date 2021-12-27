using UnityEngine;

public class ArmoryDealerNPC : Citizen
{
    [SerializeField] private DialogSystem _dialogSystem;
    protected override void InitBehaviours()
    {
        _tradable = new TradeBehavior();
        _speakable = new SimpleDialogBehavior("E", new DialogSystem());
        _movable = new DontMoveBehavior();
    }

    private void Awake()
    {
        
    }
}