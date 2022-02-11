
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    /* As we don't need call this variables with another scripts, i made them
     private but Serialized, to change them on editor */

        private Vector3 position;   
    [SerializeField] private float moveSpeed = 10;
    private string direction = ""; 
    bool movingUp = false;
    bool movingDown = false;

     bool movingRight = false;
    bool movingLeft = false;
    float zAngleUp = 15f;
    float zAngleDown = -15f;

    float xAngleRight = 90f;
    float xAngleLeft = -90f;


    void Update()
    {
        CharacterMovement();
        if (movingUp && transform.localRotation.z != 15)
        {
            RotateUpDown(zAngleUp);
        } else if (movingDown && transform.localRotation.z != -15)
        {
            RotateUpDown(zAngleDown);
        } else if (movingRight && transform.localRotation.x != 90)
        {
            RotateRightLeft(xAngleRight);
        } else if (movingLeft && transform.localRotation.x != -90)
        {
            RotateRightLeft(xAngleLeft);
        } 

        

        

    }


    // Cube moves towards wanted position using a vector3, so it can move in all directions
    void CharacterMovement()
    {
        if (Input.GetAxis("Vertical") != 0 && transform.localPosition.y <=1.0f && transform.localPosition.y >= -1.1f )
        {
            
            position = transform.localPosition;
            // valor que aumenta el movimiento en eje X
            float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

            // Verificar movimiento y establecer rotación
            if (y > 0 )
            {
                movingUp = true;
                movingDown = false;
            } else{
                movingDown = true;
                movingUp = false;
            }

            if ((position.y + y) > 1.0f)
            {
                position.y = 1.0f;
            } else if ((position.y+y) < -1.1f)
            {
                position.y = -1.1f;
            } else{
                position.y += y;
            }

            transform.localPosition = position;
            SetDirection(y, false);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            position = transform.localPosition;
            // valor que aumenta el movimiento en eje Z
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            // Verificar movimiento y establecer rotación
            if (x > 0 )
            {
                movingRight = true;
                movingLeft = false;
            } else{
                movingRight = true;
                movingLeft = false;
            }
            position.x += x;
            transform.localPosition = position;
            SetDirection(x, true);
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

    // Rotate submarine when moving up down
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
