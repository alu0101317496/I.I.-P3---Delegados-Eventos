# Autoría
**Nombre:** Lucas Hernández Abreu

**Email:** alu0101317496@ull.edu.es

# Informe
En esta práctica se nos pedía cumplimentar dos tareas

- 1 - Crear una escena simple en Unity, con dos objetos: Notificador y 
      Suscriptor y prueba el código en las transparencias.

- 2 - Crear una escena en únity, con objetos de tipo A, B y un único objeto 
      tipo C con los siguientes comportamientos:

  - 1. Cuando el jugador colisiona con un objeto de tipo b, los objetos de 
        tipo A se acercan al objeto de tipo C. Cuando el jugador toca algún 
        objeto de tipo A, el tamaño de los objetos tipo B se ve incrementado.

  - 2. Cuando el jugador se aproxima al objetivo de tipo C, los objetos de tipo
        A cambian su color y saltan, los objetos de tipo B se orientan hacia un
        objetivo ubicado a la escena. Consulta información de la clase Vector3:
        LookAt, RotateTowards, ...

  - 3. Buscar información de `Debug.DrawRay` y utilízala para depuración.

## Escena con objetos básicos:
- Escena:
![Escena](./Gifs/2.png)
- Mensajes del notificador
![Mensajes recibidos por el Notificador](./Gifs/1.png)

## Manipulación de objetos y mensajes
### Objetos:
- Tipo A: Cuadrado
- Tipo B: Cilindro
- Tipo C: Esfera blanca
### 2 - i.

![i.](./Gifs/i.gif)
![i.size](./Gifs/isize.gif)

### 2 - ii.

![ii](./Gifs/ii.gif)

`LookAt`: Es una función que recibe un `Transform` al que se orientará,
incluso rotando el propio objeto para ponerse frente al objetivo.

### 2 - iii.

![ii.ray](./Gifs/iiRay.gif)

`Debug.Ray`: Se imprime un rayo desde un punto A(`Vector3`) hasta otro punto B(`Vector3`).
Este rayo sólo se puede divisar en la Escena.
