using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public float walkSpeed;
    private Rigidbody animalRB;
    public float jumpForce;
    private void Start()
    {
        animalRB = gameObject.GetComponent<Rigidbody>();    
    }

    private void Update() 
    {
        Walk();
    }
    public virtual void Walk()
    {
        walkSpeed = 10;
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.right * walkSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    public virtual void Jump()
    {
        jumpForce = 10;
        JumpForce();
    }
    public void JumpForce()
    {
        animalRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
