
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    /* As we don't need call this variables with another scripts, i made them
     private but Serialized, to change them on editor */

        private Vector3 position;
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private string direction = ""; 

   


    void Update()
    {
        CharacterMovement();
    }


    // Cube moves towards wanted position using a vector3, so it can move in all directions
    void CharacterMovement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {

            position = transform.localPosition;
            // valor que aumenta el movimiento en eje X
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            position.x += x;
            transform.localPosition = position;
            SetDirection(x, true);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            position = transform.localPosition;
            // valor que aumenta el movimiento en eje Z
            float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            position.z += z;
            transform.localPosition = position;
            SetDirection(z, false);
        }
    }

     void SetDirection(float dirValue, bool isX)
    {
        if (isX)
        {
            if (dirValue > 0)
            {
                direction = "Derecha";
            }
            else
            {
                direction = "Izquierda";
            }
        }
        else
        {
            if (dirValue > 0)
            {
                direction = "Arriba";
            }
            else
            {
                direction = "Abajo";
            }
        }

        Debug.Log(direction);

    }



}
