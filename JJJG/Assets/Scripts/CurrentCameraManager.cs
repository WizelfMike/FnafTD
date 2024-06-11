using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCameraManager : MonoBehaviour
{

    [SerializeField] Camera deskCamera;
    [SerializeField] Camera windowCamera;
    [SerializeField] Camera clipboardCamera;

    [SerializeField] Canvas deskCanvas;
    [SerializeField] Canvas windowCanvas;
    [SerializeField] Canvas clipboardCanvas;

 
    void Start()
    {
        deskCamera.enabled = true;
        deskCanvas.enabled = true;
        windowCamera.enabled = false;
        windowCanvas.enabled = false;
        clipboardCamera.enabled = false;
        clipboardCanvas.enabled = false;
    }

    public void DeskCameraSwitch()
    {
        deskCamera.enabled = true;
        deskCanvas.enabled = true;

        windowCamera.enabled = false;
        windowCanvas.enabled = false;

        clipboardCamera.enabled = false;
        clipboardCanvas.enabled = false;
    }

    public void WindowCameraSwitch()
    {
        deskCamera.enabled = false;
        deskCanvas.enabled = false;

        windowCamera.enabled = true;
        windowCanvas.enabled = true;

        clipboardCamera.enabled = false;
        clipboardCanvas.enabled = false;
    }

    public void ClipBoardCameraSwitch()
    {
        deskCamera.enabled = false;
        deskCanvas.enabled = false;
        windowCamera.enabled = false;
        windowCanvas.enabled = false;
        clipboardCamera.enabled = true;
        clipboardCanvas.enabled = true;
    }

}
