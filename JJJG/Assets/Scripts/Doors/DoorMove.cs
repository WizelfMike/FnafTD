using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    [SerializeField] private Vector3 openPosition;
    [SerializeField] private Vector3 closedPosition;
    [SerializeField] private GameObject door;
    [SerializeField] private float desiredTime;

    [SerializeField] private ButtonToggle toggleBool;
    
    private float elapsedTime;

    private void Update()
    {
        if (toggleBool.isClosed == true)
        {
            OpenDoor();
        }

        if (toggleBool.isClosed == false)
        {
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredTime;

        //transform.position = Vector3.Lerp(currentPosition, openPosition, percentageComplete);
        door.transform.position = Vector3.MoveTowards(closedPosition, openPosition, percentageComplete);
    }

    private void CloseDoor()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredTime;

        //transform.position = Vector3.Lerp(currentPosition, closedPosition, percentageComplete);
        door.transform.position = Vector3.MoveTowards(openPosition, closedPosition, percentageComplete);
    }
}
