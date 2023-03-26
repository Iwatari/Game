using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private Door door;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            door.Open();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            door.Close();
        }
    }
}
