using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject uiButtonLeft;
    [SerializeField] private GameObject uiButtonRight;

    [SerializeField] private float minimumLeft;
    [SerializeField] private float maximumLeft;

    [SerializeField] private float minimumRight;
    [SerializeField] private float maximumRight;

    [SerializeField] private Transform playerCamera;

    void Update()
    {
        enableButtons();
    }

    public void enableButtons()
    {
        if (playerCamera.transform.localEulerAngles.y >= minimumLeft && playerCamera.transform.localEulerAngles.y <= maximumLeft)
        {
            uiButtonLeft.SetActive(true);
        }
        else
        {
            uiButtonLeft.SetActive(false);
        }


        if (playerCamera.transform.localEulerAngles.y >= minimumRight && playerCamera.transform.localEulerAngles.y <= maximumRight)
        {
            uiButtonRight.SetActive(true);
        }
        else
        {
            uiButtonRight.SetActive(false);
        }
    }
}
