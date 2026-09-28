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

<img width="426" height="240" alt="Ejercicio3-Introduccion-CSharp-Scripts" src="https://github.com/user-attachments/assets/af8f8646-0672-4e9b-bf50-c518878c4b9c" />
