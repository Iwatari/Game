using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;
    Collider2D col;
    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
    }


    void Update()
    {
        
    }

    public void Open()
    {
        anim.SetBool("Open", true);
    }
    public void Close()
    {
        anim.SetBool("Open", false);
    }
    public void Enable()
    {
        col.enabled = true;
    }
    public void Disable()
    {
        col.enabled = false;
    }
}
