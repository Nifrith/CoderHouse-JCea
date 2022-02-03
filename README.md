# Movimiento-Cea [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

Primera consigna curso coderhouse: Desarrollo de videojuegos, clase Primer vistazo a C#, Movimiento de un objeto



## Consigna

Configurar el movimiento de un objeto en una dirección determinada y escalar el objeto al poner play


## Desarrollo de actividad

- Debido a que las variables no serán accedidas por ningún otro script, las cree privadas pero serializadas, de esta manera se pueden configurar en el editor
- Son 3 variables de entrada, entre ellas:
    - Vector3 movement
    - Vector3 scale
    - float moveSpeed
- Se aumenta la escala del objeto al iniciar el juego (darle Play) en el método Start, utilizando la llamada al metodo ScaleObject() que modifica el localScale.
- Se realiza el movimiento del objeto en cada frame, llamando al método Move(), que recibe una variable parámetro de entrada tipo Vector3, que permite el movimiento del objeto en todas direcciones según los valores ingresados
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

