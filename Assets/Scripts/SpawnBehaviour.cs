
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
     // public variables here
    [SerializeField] GameObject bulletPrefab;
    
    [SerializeField] float spawnDelay = 1.0f;
    [SerializeField] float spawnInterval = 1.0f;

    public int barrelOne = 1;
    public int barrelTwo = 2;
    public int barrelThree = 3;
    public int barrelFour = 4;

    void Start()
    {
         InvokeRepeating("ShootRepeating", spawnInterval, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {   
       
    }

     void ShootMissile(int bulletAmmount)
    {    
        float posX = transform.position.x;
        for (int i = 1; i <= bulletAmmount; i++)
        {   
            Debug.Log(i);
             Instantiate(bulletPrefab, new Vector3(posX, transform.position.y,transform.position.z), bulletPrefab.transform.rotation);
             posX += -0.3f;
        }
       
    }


    void ShootRepeating()
    {
       Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }

}
