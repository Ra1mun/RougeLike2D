using UnityEngine;
[CreateAssetMenu(fileName = "NPCProperty", menuName = "Settings/NPCProperty", order = 2)]
public class NPCProperty : ScriptableObject
{
    [SerializeField] private DialogSystem _dialogSystem;

    public DialogSystem DialogSystem => _dialogSystem;
}
