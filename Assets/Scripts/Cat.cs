using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animals
{
    void Update() 
    {
        Walk();
        Jump();
    }

    public override void Walk()
    {
        walkSpeed = 5;   
        Move();
    }
    public override void Jump()
    {
        jumpForce = 10;
        if (Input.GetKeyDown(KeyCode.Space))
        {
        JumpForce();
        }
    }
}
