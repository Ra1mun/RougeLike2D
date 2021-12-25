using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    [SerializeField] private PlayerSpawner _playerSpawner;
    public override void InstallBindings()
    {
        BindPlayerHandler();
        BindInstances();
        BindInput();
        BindDetection();
    }

    private void BindPlayerHandler()
    {
        Container.BindInterfacesAndSelfTo<ClickToWorldHandler>().FromNew().AsSingle();
    }

    private void BindInstances()
    {
        Container.Bind<PlayerSpawner>().FromInstance(_playerSpawner).AsSingle();
    }

    private void BindInput()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Container.BindInterfacesAndSelfTo<MoblieInput>().FromNew().AsSingle();
        }
        else
        {
            Container.BindInterfacesAndSelfTo<MouseInput>().FromNew().AsSingle();
        }
    }
    private void BindDetection()
    {
        Container.BindInterfacesAndSelfTo<PlayerMoverDecorator>().FromNew().AsSingle();
    }
}