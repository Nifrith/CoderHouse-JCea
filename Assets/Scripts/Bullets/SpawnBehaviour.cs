
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
     // public variables here
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] float cooldown = 0.3f;

    private InputActions _inputactions;


    void Awake()
    {
        _inputactions = new InputActions();
       
    }

    // Update is called once per frame
    void Update()
    {   
       cooldown -= Time.deltaTime; 
    }

     void ShootMissile(int bulletAmmount)
    {    

        if(cooldown <= 0f){
            float posX = transform.position.x;
                for (int i = 1; i <= bulletAmmount; i++)
                {   
                    Instantiate(bulletPrefab, new Vector3(posX, transform.position.y,transform.position.z), bulletPrefab.transform.rotation);
                    posX += -0.3f;
                }
            cooldown = 0.3f;
        }  
        
       
    }

     void OnFire() {
        ShootMissile(1);
     }

    

    void ShootRepeating()
    {
       Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }

}
