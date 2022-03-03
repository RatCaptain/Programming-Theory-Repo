using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{
    void Update() 
    {
        Walk();
        Jump();
    }

    public override void Walk()
    {
        walkSpeed = 10;   
        Move();
    }
    public override void Jump()
    {
        jumpForce = 5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
        JumpForce();
        }
    }
}
