using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
 
public class RbMovement : MonoBehaviour
{

    
    public int speed;
    public Rigidbody rb;
    private Vector2 movement;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
 
    void FixedUpdate()
    {
        moveCharacter(movement);
    }
 
 
    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }
    
}
 