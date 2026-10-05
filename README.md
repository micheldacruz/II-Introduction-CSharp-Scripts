# II-Introduction-CSharp-Scripts

## Hitos relevantes
 
### Ejercicio 1

* **Uso de tipos por valor (`struct` Color):** Manipulación de componentes de color (RGB) mediante indexación (`color[i]`) usando variables locales para evitar limitaciones de modificación directa en propiedades.
* **Manejo de aleatoriedad con la clase Random:** Generación de valores continuos en el rango `[0.0, 1.0]` con `Random.value` y selección de índices discretos `[0, 2]` mediante `Random.Range`.
* **Control de ejecución por frames:** Sincronización del cambio de estado cada 120 fotogramas utilizando el operador módulo sobre la propiedad `Time.frameCount`.

<img width="426" height="240" alt="Ejercicio1-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/3fbf3aea-d7b8-441c-b6d9-1e00c9da223e" />

### Ejercicio 2

* **Operaciones vectoriales con `Vector3`:** Cálculo directo de magnitudes (`Vector3.magnitude`), distancia euclidiana (`Vector3.Distance`) y el ángulo entre dos vectores (`Vector3.Angle`) mediante los métodos estáticos de la API de Unity.
* **Evaluación de componentes posicionales:** Comparación explícita de la coordenada `y` de los vectores para determinar y clasificar cuál se encuentra a mayor altura en el espacio tridimensional.
* **Formateo e interconectividad con la consola:** Salida estructurada de información en la consola mediante `Debug.Log` usando interpolación de cadenas de texto (`$""`).

<img width="1532" height="748" alt="Ejercicio2-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/0c93b743-1261-4ed5-a4de-89ac2629bea6" />

### Ejercicio 3

* **Acceso a componentes fundamentales:** Acceso directo a las propiedades del objeto a través del componente `Transform` para la gestión espacial dentro de la escena.
* **Obtención de datos posicionales:** Recuperación en tiempo de ejecución de las coordenadas tridimensionales de la esfera mediante la propiedad `transform.position`.

<img width="1532" height="730" alt="Ejercicio3-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/0fccdff1-7c4a-4b33-be5c-5ee126092b5e" />

### Ejercicio 4

* **Búsqueda dinámica de objetos mediante etiquetas (*Tags*):** Localización en tiempo de ejecución de entidades externas en la escena (`Cubo` y `Cilindro`) usando la función de la API `GameObject.FindWithTag`.
* **Referencias cruzadas entre GameObjects:** Recuperación de los componentes `Transform` de los objetos encontrados para acceder a sus propiedades de posición espacial.

<img width="1694" height="864" alt="Ejercicio4-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/46cb8344-f376-4ebd-9746-9acbbe681f6e" />

### Ejercicio 5

* **Detección de eventos de entrada (*Input*):** Captura de la interacción del usuario mediante `Input.GetAxis("Jump")` para detectar la pulsación de la barra espaciadora a través del sistema de entrada virtual de Unity.
* **Transformación y desplazamiento posicional:** Aplicación de offsets vectoriales acumulativos sobre las coordenadas globales del objeto (`transform.position += desplazamiento`).

<img width="1536" height="752" alt="Ejercicio5-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/fae649b2-064d-40d8-8fce-1c13950b8308" />

### Ejercicio 6

* **Detección discreta de teclas mediante enumerados (`KeyCode`):** Captura de eventos de pulsación individual en un único fotograma utilizando `Input.GetKeyDown` junto con las constantes de dirección (`UpArrow`, `DownArrow`, `LeftArrow`, `RightArrow`).
* **Lectura de ejes virtuales de movimiento:** Procesamiento de las entradas directas a través de los ejes virtuales `Horizontal` y `Vertical` de la clase `Input`.

<img width="1528" height="774" alt="Ejercicio6-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/f9febc6a-f8d7-406c-a97d-641689b47b56" />

### Ejercicio 7

* **Configuración del Input Manager:** Reasignación y personalización de ejes virtuales de entrada a nivel de proyecto desde `Edit > Project Settings > Input Manager`.

<img width="1594" height="778" alt="Ejercicio7-Introduccion-CSharp-Scripts (1)" src="https://github.com/user-attachments/assets/2e388c94-a052-461a-a019-6111b46ded27" />

### Ejercicio 8

* **a. Duplicar las coordenadas de la dirección (`moveDirection`):** Si no se normaliza el vector (`.normalized`), duplicar sus componentes duplica su magnitud, provocando que el cubo se mueva al doble de velocidad. Si el vector está normalizado, duplicar sus valores no altera la velocidad final, ya que la dirección mantiene su vector unitario.
* **b. Duplicar la velocidad (`speed`):** Manteniendo la dirección constante, al duplicar la variable escalar de velocidad el objeto recorre el doble de distancia por unidad de tiempo de forma directamente proporcional.
* **c. Velocidad menor que 1 (`speed < 1`):** El movimiento del objeto se ralentiza proporcionalmente a la fracción configurada, pero sigue conservando la traslación fluida e independiente de fotogramas al estar respaldado por `Time.deltaTime`.
* **d. Posición inicial con $y > 0$:** La coordenada $Y$ inicial no afecta internamente a la lógica de traslación del script; sin embargo, establecer $y = 0$ inicialmente permite estandarizar el punto de partida y observar con claridad si el vector de movimiento incluye o no desplazamiento en el eje vertical.
* **e. Movimiento local vs. mundial (`Space.Self` vs `Space.World`):** 
  * Usar el **sistema local** (`Space.Self`, por defecto en `Translate`) mueve el objeto respecto a su propia orientación y ejes de rotación.
  * Usar el **sistema mundial** (`Space.World`) mueve el objeto fijándose en las coordenadas absolutas de la escena, ignorando hacia dónde esté girado el objeto.

<img width="1772" height="852" alt="Ejercicio8-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/6880119d-905f-45d1-9bf5-2a5369691b29" />

### Ejercicio 9

* **Independencia de esquemas de control:** Implementación de dos sistemas de entrada diferenciados en scripts independientes para permitir el control multijugador o simultáneo de dos entidades en la misma escena (WASD para la esfera y Flechas de dirección para el cubo).
* **Captura de entrada continua en tiempo real:** Uso de `Input.GetKey` para mantener la traslación fluida y constante en cada fotograma mientras la tecla permanezca presionada por el usuario.
* **Uso del espacio de coordenadas mundial (`Space.World`):** Aplicación explícita del parámetro `Space.World` en el método `transform.Translate` para asegurar que las direcciones del movimiento mantengan una orientación absoluta en la escena, independientemente de la rotación propia del objeto.
* **Escalado temporal del movimiento:** Integración de la propiedad `Time.deltaTime` junto con una variable parametrizable `speed` para garantizar una velocidad uniforme independientemente del rendimiento del sistema (*frame rate*).

<img width="1770" height="854" alt="Ejercicio9-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/1944ab2a-7a85-4dbb-ae36-e90b7b35c880" />

