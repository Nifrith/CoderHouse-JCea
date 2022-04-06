
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
     // public variables here
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] float cooldown = 1.5f;

    public int barrelOne = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
       cooldown -= Time.deltaTime; 
       if(Input.GetKeyDown(KeyCode.J)){
            ShootMissile(barrelOne);
       }
    }

     void ShootMissile(int bulletAmmount)
    {    
        if(cooldown <= 0f){
            float posX = transform.position.x;
                for (int i = 1; i <= bulletAmmount; i++)
                {   
                    Debug.Log(i);
                    Instantiate(bulletPrefab, new Vector3(posX, transform.position.y,transform.position.z), bulletPrefab.transform.rotation);
                    posX += -0.3f;
                }
            cooldown = 0.3f;
        }  
        
       
    }


    

    void ShootRepeating()
    {
       Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }

}
