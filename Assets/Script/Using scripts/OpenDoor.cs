using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Door door;
    void Start()
    {
    }  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            door.Open();
        }
    }
}
