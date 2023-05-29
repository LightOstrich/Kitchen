using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    [SerializeField] private Waffle _waffle;
    [SerializeField] private GameObject _waffleRootCordinate;
    private Toaster _toaster;

    private void Awake()
    {
        _toaster = FindObjectOfType<Toaster>();
    }


    private void OnEnable()
    {
        _toaster.TimerIsUp += OnTimerIsUp;
    }

    private void OnDisable()
    {
        _toaster.TimerIsUp -= OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        Instantiate(_waffle, _waffleRootCordinate.transform.position,
            _waffleRootCordinate.transform.rotation);
    }
}