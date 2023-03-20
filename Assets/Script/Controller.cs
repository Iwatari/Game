using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10.0f;
    public float forwardInput;
    public float UpInput;
    void FixedUpdate()
    {
        UpInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime * UpInput);
        forwardInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime * forwardInput);
    }
}
