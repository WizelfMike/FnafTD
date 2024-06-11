using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] UnityEvent OnClick;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            OnClick.Invoke();
        }
    }
}
