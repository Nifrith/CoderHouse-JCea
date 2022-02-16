# Josue-Cea_Desafío 3 - Complementario [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

Tercera consigna . desafío complementario curso coderhouse: Desarrollo de videojuegos, clase Modificación de GameObjects: Prefabs , Instanciación de balas

## Consigna

Crear funcion que permita disparar: 2, 3 o 4 balas dependiendo de la tecla presionada: J, K y L respectivamente.

## Desarrollo de actividad

- Se agrega método para destruir las balas después de dos segundos, utilizando una lógica de impulso calculado con Time.deltaTime;

- Se mantiene el escenario, la música, las texturas y sonidos
- Se modificaron las partículas de fuego para que sean más coherentes con los disparos

- Se modifico el método Cannon() de SpawnBehaviour, cambiandolo por ShootBullet, que recibe un parámetro de entrada tipo float para cálcular las instancias de gameObject tipo balas.

- Los metodos agregados separados por script son: 
    - BulletBehaviour.cs : 

    ```c
            impulse -= Time.deltaTime;


            private void DestroyBullet(float impulse)
                {   
                if(impulse <= 0f){
                    Debug.Log("Bullet lost impulse");
                    Destroy(gameObject);
                }   
            }

    ```

    - SpawnBehaviour.cs: Se añadieron variables señaladas con barrel (El barril es la zona donde se introduce la bala en un arma) en este caso, misiles o torpedos.
        ```c

            // Variables públicas para ser modificadas dependiendo de lo que pase en el juego (powerups, aumento de balas, etc)

            public float barrelOne;
            public float barrelTwo;
            public float barrelThree;
            public float barrelFour;


             // Se controla también la distancia de aparición entre misiles, para que no aparezcan superpuestos
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

        ```
- Se modificaron también los métodos de takeHeal y takeDamage, en caso de que se requieran utilizar por mecánicas del juego.
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

