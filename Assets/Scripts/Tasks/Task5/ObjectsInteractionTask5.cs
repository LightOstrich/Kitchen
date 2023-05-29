using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    private Shelf[] _shelves;

    private void Awake()
    {
        _shelves = FindObjectsOfType<Shelf>();
    }

    private void OnEnable()
    {
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += OnFall;
        }
    }

    private void OnDisable()
    {
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned -= OnFall;
        }
    }

    private void OnFall()
    {
        foreach (var shelf in _shelves)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }
}