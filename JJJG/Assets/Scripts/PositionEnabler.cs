using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionEnabler : MonoBehaviour
{
    [SerializeField] private float rotationPoint;
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private GameObject changeButton;

    private void Start()
    {
        changeButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (cameraObject.transform.eulerAngles.y < rotationPoint)
        {
            changeButton.gameObject.SetActive(true);
        }
    }
}
