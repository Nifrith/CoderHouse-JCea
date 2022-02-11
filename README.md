# Josue-Cea_Desafío 2 [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

Tercera consigna curso coderhouse: Desarrollo de videojuegos, clase Modificación de GameObjects: Prefabs , Instanciación de balas

## Consigna

Crear prefab de bala con variables expuestas speed, direction y damage. La bala debe moverse en la dirección establecida en la variable direction, a la velocidad establecida en la variable speed.
Se debe crear además un script Cannon() conteniendo el método Disparo, para así poder realizar el instanciamiento
## Desarrollo de actividad

- Debido a que las variables no serán accedidas por ningún otro script, las cree privadas pero serializadas, de esta manera se pueden configurar en el editor, a excepción de las variables tipo GameObject

- Me gusta generar escenarios cada vez que puedo, en este caso, generé un escenario submarino y un prefab de submarino (creación propia), utilizando environments 
de assetStore, le incluí música y efectos de partículas para simualar burbujas.

- Preferí crear dos scripts diferentes para trabajar diferentes aspectos de la lógica
    - BulletBehaviour.cs : Contiene la lógica de movimiento de la bala, dirección, velocidad, etc
        - Se utilizo un prefab de misil descargado de la asset store
        
    - SpawnBehaviour.cs: Contiene la lógica relacionada con atributos, tales como salud actual, salud máxima, daño.
        - Cree un punto de aparición dentro del prefab Submarino, que servirá de referencia para la salida de cada una de las balas. El script contiene la lógica
        de instanciación de los prefab misiles

- Los metodos agregados separados por script son: 
    - BulletBehaviour.cs : 

    ```c
        private void MoveBullet(Vector3 vector3) Recibe una variable Vector3, no obstante, se controla con los enum direction, dependiendo de la selección en el editor
        {
        transform.position += bulletSpeed * Time.deltaTime * vector3;
        }


        public enum Direction
        {
            up,
            down,
            left,
            right
        }
    ```

    - SpawnBehaviour.cs: Se utiliza una variable GameObject llamada bulletPrefab para instancia las balas, en este caso, misiles o torpedos.
        ```c
        void Cannon()
            {
                Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            }   
        ```
- Se realiza el movimiento de las balas en cada frame, llamando al método MoveBullet() dependiendo de la dirección elegida.
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

