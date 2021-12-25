using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] private PlayerDecorator _playerDecorator;
    
    private void Start()
    {
        BindInput();
    }

    private void BindInput()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
            _playerDecorator.Init(GetComponent<MoblieInput>());
        else
            _playerDecorator.Init(GetComponent<MoblieInput>());
    }
}
