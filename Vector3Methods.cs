using UnityEngine;

// Ejercicio 2
public class Vector3Methods : MonoBehaviour
{
    [Header("Entrada")]
    public Vector3 vectorA;
    public Vector3 vectorB;

    [Header("Resultados (Inspector)")]
    public float magnitudA;
    public float magnitudB;
    public float angulo;
    public float distancia;
    public string comparacionAltura;

    void Start()
    {
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;
        angulo = Vector3.Angle(vectorA, vectorB);
        distancia = Vector3.Distance(vectorA, vectorB);

        if (vectorA.y > vectorB.y)
        {
            comparacionAltura = "El vector A está a mayor altura";
        }
        else if (vectorA.y < vectorB.y)
        {
            comparacionAltura = "El vector B está a mayor altura";
        }
        else
        {
            comparacionAltura = "Ambos vectores están a la misma altura";
        }

        Debug.Log(
            $"Magnitud vector A: {magnitudA}\n" +
            $"Magnitud vector B: {magnitudB}\n" +
            $"Ángulo entre ambos vectores: {angulo}\n" +
            $"Distancia entre ambos vectores: {distancia}\n" +
            $"{comparacionAltura}"
        );

        // Ejercicio 3
        Debug.Log($"Posición de la esfera: {transform.position}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
