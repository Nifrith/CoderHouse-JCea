# Herencia - Cea : Herencias y scriptable objects [![Unity](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es)

## Consigna

- Se solicita una escena del proyecto final donde 
  - Haya al menos un caso de herencia justificado
  - Se utilicen al menos dos scriptables objects distintos

## Desarrollo de actividad

- Se agrega script para identificar los tipos de balas
   - A partir de este script, se heredan los métodos y atributos a dos tipos de misiles
    - Misil normal : misil más lento y con una vida más corta
    - Misil dirigido: misil más rápido y con una vida más larga (tarda más en desaparecer)

- En caso de los scriptable objects, se agregaron dos tipos
  - Scriptable object: Bullet
    - Se utiliza un enumerador para definir el tipo de bala
      - Normal: bala normal que recorre una trayectoria fija horizontal hacia la derecha de la pantalla
      - Omega: tipo de bala que explota luego de 2 segundos, elimina a todos los enemigos del mapa, le aplica 2 puntos de daño a los enemigos tipo jefe
      - Multi: tipo de bala multiple, se divide en un abanico después de 1 segundo
      - Directed: tipo de bala dirigida, se dispara cada 4 segundos y golpea al enemigo más cercano de forma dirigida.
  - Scriptable object: Enemy
   - Se utiliza un enumerador para definir el tipo de jefe
    - Left: enemigo que se mueve en horizontal hacia la izquierda de la pantalla
    - Updown: tipo de enemigo que se mueve arriba y abajo de manera errática, también tiene la habilidad de disparar
    - Shooter: Tipo de enemigo que dispara con trayectoria horizontal hacia la izquierda de la pantalla
    - Boss: Tipo de enemigo final, el daño no se le aplica de la misma manera que a los demás

## Modificaciones adicionales
### Interfaz
* Se genera una pequeña interfaz de tipo retrato a modo de prueba
### Jugabilidad
* Se modifica tipo de movimiento del submarino, ahora se realiza mediante aplicación de fuerza de tipo impulso
* Se modifica forma de disparar, al presionar la tecla J
## Autor

- [@Josue Cea](https://www.github.com/Nifrith)

