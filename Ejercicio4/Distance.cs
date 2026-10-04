using UnityEngine;

// Ejercicio 4
public class Distance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cube = GameObject.FindWithTag("Cube");
        GameObject cylinder = GameObject.FindWithTag("Cylinder");

        Debug.Log(
            $"Distancia al cubo: {Vector3.Distance(transform.position, cube.transform.position)}\n" +
            $"Distancia al cilindro: {Vector3.Distance(transform.position, cylinder.transform.position)}"
        );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
