using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskMoveCamera : MonoBehaviour
{
    [SerializeField] private float maxRotation = 235;
    [SerializeField] private float minRotation = 125;

    [SerializeField] private float rotationSpeed = 45f;

    private bool movingLeft;
    private bool movingRight;

    private void Update()
    {
        if (movingRight && this.transform.localEulerAngles.y < maxRotation)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if (movingLeft && this.transform.localEulerAngles.y > minRotation)
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }

    public void rotateLeft()
    {
        movingLeft = true;
    }
    public void rotateRight()
    {
        movingRight = true;
    }
    public void stopRotateLeft()
    {
        movingLeft = false;
    }
    public void stopRotateRight()
    {
        movingRight = false;
    }
}
