using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RbMovement : MonoBehaviour
{
    public int speed;
    public Rigidbody rb;
    private Vector3 movement;

    private float moveHorizontal;
    private float moveVertical;
 
 
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
 
    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }
 
 
    void FixedUpdate()
    {
        moveCharacter(movement);
    }
 
 
    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }

     void RotateUpDown(float zAngle){
        float x = transform.rotation.x;
        transform.rotation = Quaternion.Euler(0, 90, zAngle) ;
    }

     void RotateRightLeft(float xAngle){
         float z = transform.rotation.z;
         Debug.Log(z);
        transform.rotation = Quaternion.Euler(0, xAngle, 0) ;
    }
    
}
 