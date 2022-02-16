# Josue-Cea_Desafío 4 - Disparos Temporizados [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

Cuarta consigna . desafío complementario curso coderhouse: Desarrollo de videojuegos, clase Inputs y flow temporal , Instanciación de balas

## Consigna

Crear un objeto que instancie balas cada cierto tiempo, las cuales deben destruirse después de un tiempo determinado (ajustable por inspector) y si pulsamos la barra espaciadora
dupliquen su tamaño.

## Desarrollo de actividad

- Se agrega método para destruir las balas después de dos segundos, utilizando una lógica de impulso calculado con Time.deltaTime;

- Se mantiene el escenario, la música, las texturas y sonidos
- Se modificaron las partículas de fuego para que sean más coherentes con los disparos

- Se creo un método adicional en SpawnBehaviour.cs llamado ShootRepeating para utilizar con el método invokeRepeating. Dicho método es utilizado usando parámetros de entrada para el delay de inicio y las repeticiones 

- Los metodos agregados separados por script son: 
    - BulletBehaviour.cs : 

    ```c
            impulse -= Time.deltaTime;


             void BulletGrow(float growth)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    transform.localScale = transform.localScale * growth;
                    Debug.Log(transform.localScale);

                }
            }  

    ```

    - SpawnBehaviour.cs: Se añadieron variables señaladas con barrel (El barril es la zona donde se introduce la bala en un arma) en este caso, misiles o torpedos.
        ```c

            void Start()
            {
                InvokeRepeating("ShootRepeating", spawnInterval, spawnDelay);
            }

            void ShootRepeating()
            {
            Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            }


        ```
- Se modificaron también los métodos de takeHeal y takeDamage, en caso de que se requieran utilizar por mecánicas del juego.
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

