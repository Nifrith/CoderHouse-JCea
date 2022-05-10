
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     // Public variables from here
    public float damage;
    public int bulletSpeed = 5;
    public float lifeSpan = 5;

    Rigidbody2D rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootBullet(Vector3.right);
        lifeSpan -= Time.deltaTime;
        DestroyBullet(lifeSpan); 

    }

    public void ShootBullet(Vector3 vector3)
    {
       rb.velocity = vector3 * bulletSpeed * 2;

    }

    public void DestroyBullet(float impulse)
    {   
        if(impulse <= 0f){
            Destroy(gameObject);
        }   
    }
    
}
