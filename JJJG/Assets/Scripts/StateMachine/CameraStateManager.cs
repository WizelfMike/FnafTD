using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateManager : MonoBehaviour
{

    private CameraBaseState currentState;
    public CameraDeskState deskState = new CameraDeskState();
    public CameraWindowState windowState = new CameraWindowState();
    public CameraClipboardState clipboardState = new CameraClipboardState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = deskState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(CameraBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
