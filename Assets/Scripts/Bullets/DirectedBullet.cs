using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectedBullet : Bullet
{
    void Awake()
    {
     damage = 5f;
     bulletSpeed = 30;
     lifeSpan = 5;
    }
    void Update()
    {
        ShootBullet(Vector3.right);
        lifeSpan -= Time.deltaTime;
        DestroyBullet(lifeSpan); 
    }

    // Update is called once per frame

}
