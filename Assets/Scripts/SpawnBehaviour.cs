using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
     // public variables here
    [SerializeField] GameObject bulletPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.J)){
             Cannon();
         }
    }

     void Cannon()
    {
        Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }
}
