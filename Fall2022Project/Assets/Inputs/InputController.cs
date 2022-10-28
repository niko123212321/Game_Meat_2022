using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[Serializable]
public class MoveInputEvent : UnityEvent<float, float> { }


public class InputController : MonoBehaviour
{
    Fall2022Project controlsIThink;
    public MoveInputEvent moveInputEvent;

    private void Awake()
    {
        controlsIThink = new Fall2022Project();
    }
    private void OnEnable()
    {
        
    }
}
