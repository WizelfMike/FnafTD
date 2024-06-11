using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDeskState : CameraBaseState
{
    public override void EnterState(CameraStateManager camera)
    {
        
    }

    public override void UpdateState(CameraStateManager camera)
    {
        
    }

    public void SwitchToWindow(CameraStateManager camera)
    {
        camera.SwitchState(camera.windowState);
        
    }

    public void SwitchToClipboard(CameraStateManager camera)
    {
        camera.SwitchState(camera.clipboardState);
    }
}
