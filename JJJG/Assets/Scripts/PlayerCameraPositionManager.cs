using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraPositionManager : MonoBehaviour
{

    [SerializeField] private List<Transform> playerPositions;

    [SerializeField] private Camera playerCamera;

    void Start()
    {
        playerCamera.transform.position = playerPositions[0].transform.position;

        playerCamera.transform.rotation = playerPositions[0].transform.rotation;
    }

    public void MoveToPosition(int cameraPosition)
    {
        playerCamera.transform.position = playerPositions[cameraPosition].transform.position;

        playerCamera.transform.rotation = playerPositions[cameraPosition].transform.rotation;
    }
}
