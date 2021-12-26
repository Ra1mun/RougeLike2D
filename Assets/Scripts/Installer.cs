using System;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{

    [SerializeField] private Player _player;
    [SerializeField] private PlayerMovement _playerMovement;

    public override void InstallBindings()
    {
        BindInstances();
        BindPlayerIntaractHandler();
        BindInput();
        BindDetection();
        BindGeneral();
    }

    private void BindInstances()
    {
        Container.Bind<Player>().FromInstance(_player).AsSingle();
        Container.Bind<PlayerMovement>().FromInstance(_playerMovement).AsSingle();
    }

    private void BindPlayerIntaractHandler()
    {
        Container.BindInterfacesAndSelfTo<IconChooseHandler>().FromNew().AsSingle();
        Container.BindInterfacesAndSelfTo<MovementHandler>().FromNew().AsSingle();
    }

    private void BindDetection()
    {
        Container.BindInterfacesAndSelfTo<ClickDecorator>().FromNew().AsSingle();
    }

    private void BindInput()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Container.BindInterfacesAndSelfTo<MoblieClick>().AsSingle();
            Container.BindInterfacesAndSelfTo<MoblieInput>().AsSingle();
        }
        else
        {
            Container.BindInterfacesAndSelfTo<MouseClick>().AsSingle();
            Container.BindInterfacesAndSelfTo<KeyboardInput>().AsSingle();
        }
    }

    private void BindGeneral()
    {
        Container.Bind<Camera>().FromInstance(Camera.main).AsSingle();
    }
}