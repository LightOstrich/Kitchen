using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] _lamps;

    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    private void Awake()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Keypad2))
        {
            foreach (var lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
  
}