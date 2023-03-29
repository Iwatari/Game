using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Door door;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            door.Open();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            door.Close();
        }
    }
  

    /* public void OnTriggerEnter2D(Collider2D collision)
      {
          if (collision.tag == "Player")        
          {
               door.Disable();
          }

      }
      public void OnTriggerExit2D(Collider2D collision)
       {
          if (collision.tag == "Player")

              {
                  door.Enable();
              }
      }
    */
   
}
