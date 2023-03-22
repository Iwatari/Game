using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject pointPortal;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Coin")
        {
            collision.transform.position = pointPortal.transform.position;
        }

    }
}
