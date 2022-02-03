
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    /* As we don't need call this variables with another scripts, i made them
     private but Serialized, to change them on editor */
    [SerializeField] private Vector3 movement;
    [SerializeField] private Vector3 scale;

    // I added a moveSpeed variable to control how fast object moves
    [SerializeField] private float moveSpeed;

    // On Start method, i set the new localScale of the object
    void Start() { 
        ScaleObject(scale);
    }

    // Update is called once per frame
    // Move method is called every frame
    void Update()
    {
        Move();
    }


    // Object is scaled using a parameter variable, in this case, we will be adding wanted scale to localScale
    void ScaleObject(Vector3 qttyToScale){

        transform.localScale += qttyToScale;

    }


    // Cube moves towards wanted position using a vector3, so it can move in all directions
    void Move(){
        transform.position += (movement * moveSpeed * Time.deltaTime);
    }


}
