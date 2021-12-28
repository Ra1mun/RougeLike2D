using System;
using Zenject;

public class InteractWithNPCHandler : IInitializable, IDisposable
{
    private readonly PlayerInteract _playerInteract;

    public InteractWithNPCHandler(PlayerInteract playerInteract)
    {
        _playerInteract = playerInteract;
    }

    public void Initialize()
    {
        _playerInteract.OnInteracted += Interacted;
    }

    private void Interacted(Citizen citizen)
    {
        citizen.Speak();
    }

    public void Dispose()
    {
        _playerInteract.OnInteracted -= Interacted;
    }
}