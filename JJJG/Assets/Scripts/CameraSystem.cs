using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [Header("Camera Positions")]
    [SerializeField] private List<Transform> camPositions;
    [Header("The Camera")]
    [SerializeField] private Transform secCamera;

    private void Start()
    {
        secCamera.position = camPositions[0].transform.position;
        secCamera.rotation = camPositions[0].transform.rotation;
    }

    public void ChangePosition(int cameraNumber)
    {
        secCamera.position = camPositions[cameraNumber].transform.position;
        secCamera.rotation = camPositions[cameraNumber].transform.rotation;
    }
}
