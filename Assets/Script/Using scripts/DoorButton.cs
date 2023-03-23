using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private UsingLever door;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
         {
            door.OpenDoor();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            door.CloseDoor();
        }
    }
}
