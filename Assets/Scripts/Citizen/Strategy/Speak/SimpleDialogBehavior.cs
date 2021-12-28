using UnityEngine;

public class SimpleDialogBehavior: ISpeakable
{
    private string _characterKey;
    private DialogSystem _dialogSystem;

    public SimpleDialogBehavior(string characterKey, DialogSystem dialogSystem)
    {
        _characterKey = characterKey;
        _dialogSystem = dialogSystem;
    }

    public void Speak()
    {
        Debug.Log("I can speak");
    }
}
