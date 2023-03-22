using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float forwardInput;
    public float UpInput;
  
    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("AltHorizontal");
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime * forwardInput);

    }

}
