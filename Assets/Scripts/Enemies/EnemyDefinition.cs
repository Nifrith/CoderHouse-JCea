using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newEnemy" , menuName = "My Assets/create enemy")]
public class EnemyDefinition : ScriptableObject
{
    public enum EnemyType{Left, UpDown, Shooter, Boss};
    public EnemyType enemyType;

    #region basic enemy trait
    [Header ("Basic enemy trait")]
    public GameObject enemyPrefab;
    public int moveSpeed;
    public float health;
    public float damage;
    public float bulletRate;

    public float shootCooldown;
    #endregion

    #region Boss lifes 
        [Tooltip ("Only has effect if boss type is set to Multi")]
        public float lifes = 7;
    #endregion


}
