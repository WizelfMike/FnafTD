using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonToggle : MonoBehaviour
{
    public bool isClosed = false;
    private bool canBeClicked;

    [SerializeField] private Vector3 openPosition;
    [SerializeField] private Vector3 closedPosition;
    [SerializeField] private Vector3 doorTarget;
    [SerializeField] private GameObject door;
    [SerializeField] private float desiredTime;

    private float elapsedTime;

    private void Start()
    {
        isClosed = false;
        canBeClicked = true;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && canBeClicked)
        {
            isClosed = !isClosed;
        }
    }

    private void Update()
    {
        if (isClosed)
        {
            CloseDoor();
        }

        if(!isClosed)
        {
            OpenDoor();
        }

        if (door.transform.position == openPosition | door.transform.position == closedPosition)
        {
            elapsedTime = 0f;
        }
    }

    private void OpenDoor()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredTime;

        //transform.position = Vector3.Lerp(currentPosition, openPosition, percentageComplete);
        door.transform.position = Vector3.MoveTowards(door.transform.position, openPosition, percentageComplete);
    }

    private void CloseDoor()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredTime;

        //transform.position = Vector3.Lerp(currentPosition, closedPosition, percentageComplete);
        door.transform.position = Vector3.MoveTowards(door.transform.position, closedPosition, percentageComplete);
    }
}
