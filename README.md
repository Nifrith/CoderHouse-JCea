# Josue-Cea_Desafío 2 [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

Segunda consigna curso coderhouse: Desarrollo de videojuegos, clase Debugging y funciones propias , Primera implementación de mecánica

## Consigna

Crear un script que contenga las variables: vida, velocidad, dirección, Se deberá crear además un método que controle movimiento, otro que cure al jugador y otro método que dañe al jugador.

## Desarrollo de actividad

- Debido a que las variables no serán accedidas por ningún otro script, las cree privadas pero serializadas, de esta manera se pueden configurar en el editor
- Preferí crear dos scripts diferentes para trabajar diferentes aspectos de la lógica
    - CharacterController.cs : Contiene la lógica de movimiento y dirección del personaje
    - CharacterAttributesController.cs: Contiene la lógica relacionada con atributos, tales como salud actual, salud máxima, daño.
- Agregué 4 métodos nuevos:
    - Movement();
    - SetDirection(float dirValue, bool isX); En este caso, setDirection trabaja junto con el método Movement() para establecer la dirección hacia la cuál se mueve el personaje, dependiendo de los valores obtenidos de Input.GetAxis();
    - TakeHeal(); Se implemento con la tecla espacio una pequeña curación de 10 puntos.
    - TakeDamage(); Se implemento con la tecla alt izquierda una pequeña aplicación de daño por 5 puntos.
    - Si el personaje tiene la salud al máximo, no podrá curarse, de igual modo, si tiene la salud agotada, no podrá seguir recibiendo daño.

- Se realiza el movimiento del objeto en cada frame, llamando al método Movement(), que recibe variables de entrada mediante Inputs de teclado, permitiendo establecer de manera dinámica la dirección del personaje (La primitiva en este caso)
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

