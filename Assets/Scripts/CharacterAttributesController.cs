using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttributesController : MonoBehaviour
{


    [SerializeField] private int health = 50; 
    [SerializeField] private int maxHealth = 100; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Health is: "+ health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeHeal(10);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            TakeDamage(5);
        }
    }

    // Method for healing
    void TakeHeal(int healing)
    {
        if ((healing + health) > maxHealth)
        {
            health = maxHealth;
            Debug.Log("Can't heal, Health is full");
        }
        else
        {
            health += healing;
            Debug.Log("heal received, health now is: " + health);
        }

        
    }

    // Method for receiveing damage
    void TakeDamage(int damage)
    {
        if (damage > health)
        {
            health = 0;
            Debug.Log("Already Dead");
        }
        else
        {
            float lowHealth = maxHealth * 0.20f; 
            health -= damage;
            Debug.Log("Damage taken, life now is: " + health);
            if (health <= lowHealth)
            {
                Debug.Log("Caution, low Health");
            }
        }


    }


}
