
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
     // Public variables from here
    [SerializeField] float damage;
    [SerializeField] float bulletSpeed;
    [SerializeField] float impulse;

    // Direction should be: right, left, up , down , forward, back
    [SerializeField] Direction bulletDirection;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         switch (bulletDirection)
        {
            case Direction.right:
                MoveBullet(Vector3.right);
                break;
            case Direction.left:
                MoveBullet(Vector3.left);
                break;
            case Direction.up:
                MoveBullet(Vector3.up);
                break;
            case Direction.down:
                MoveBullet(Vector3.down);
                break;
        }

        impulse -= Time.deltaTime;
        DestroyBullet(impulse); 
        
    }

    private void MoveBullet(Vector3 vector3)
    {
       transform.position += bulletSpeed * Time.deltaTime * vector3;

    }

     private void DestroyBullet(float impulse)
    {   
        if(impulse <= 0f){
            Debug.Log("Bullet lost impulse");
            Destroy(gameObject);
        }   
    }


     public enum Direction
    {
        up,
        down,
        left,
        right
    }
}
