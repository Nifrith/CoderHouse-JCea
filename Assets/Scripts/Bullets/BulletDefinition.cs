using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newBullet" , menuName = "My Assets/create bullet")]
public class BulletDefinition : ScriptableObject
{
    public enum BulletType{Normal, Directed, Omega, Multi};
    public BulletType bulletType;

    #region basic bullet trait
    [Header ("Basic bullet trait")]
    public GameObject bulletPrefab;
    public int bulletSpeed;
    public float lifespan;
    public float damage;
    public float qttyBulletsToFire;

    public float shootCooldown;
    #endregion

    #region fireRate 
        [Tooltip ("Only has effect if bullet type is set to Multi")]
        public float missileQtty = 1;
    #endregion


}
