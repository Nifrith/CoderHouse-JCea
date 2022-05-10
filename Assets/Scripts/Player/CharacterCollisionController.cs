using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionController : MonoBehaviour
{

    Rigidbody rb;
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) 
 {
         if(collision.gameObject.tag == "Bounds")  // or if(gameObject.CompareTag("YourWallTag"))
         {
                     rb.velocity = new Vector3(3,3,0);
         }
 }
}
