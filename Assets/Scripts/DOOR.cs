using UnityEngine;

public class Door : MonoBehaviour
{
    public PullZone pullZone;          // Drag your PullZone object here in the Inspector
    public Transform doorCenterPoint;  // Drag an empty GameObject placed in the doorway
    public bool isOpen = false;

    void Update()
    {/*
        // TESTING: Press "E" to toggle the door open/closed
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isOpen) CloseDoor();
            else OpenDoor();
        } */
        if (isOpen) CloseDoor();
        else OpenDoor();
    }

    public void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Door is now open");

        if (pullZone != null)
        {
            Debug.Log("I'm not NULL");
            pullZone.doorOpen = true;              // Activate pulling
            pullZone.pullTarget = doorCenterPoint; // Set pull target
        }
        else {
            Debug.Log("I'm NULL ");
        }
    }

    public void CloseDoor()
    {
        isOpen = false;
        Debug.Log("Door is now closed");

        if (pullZone != null)
        {
            pullZone.doorOpen = false; // Stop pulling
        }
    }
}

