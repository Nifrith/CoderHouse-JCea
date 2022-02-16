
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
     // public variables here
    [SerializeField] GameObject bulletPrefab;

    public int barrelOne = 1;
    public int barrelTwo = 2;
    public int barrelThree = 3;
    public int barrelFour = 4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
             ShootMissile(barrelOne);
         }
        
        if (Input.GetKeyDown(KeyCode.J)){
             ShootMissile(barrelTwo);
         }

        if (Input.GetKeyDown(KeyCode.K)){
             ShootMissile(barrelThree);
         }

        if (Input.GetKeyDown(KeyCode.L)){
             ShootMissile(barrelFour);
         }
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
}
