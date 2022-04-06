using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
   void Awake()
    {
     damage = 5f;
     bulletSpeed = 20;
     lifeSpan = 5;
    }
    void Update()
    {
        MoveBullet(Vector3.right);
        lifeSpan -= Time.deltaTime;
        DestroyBullet(lifeSpan); 
    }
}
