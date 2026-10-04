using UnityEngine;

// Ejercicio5
public class Desplazamiento : MonoBehaviour
{
    public Vector3 desplazamiento;
    private bool yaDesplazado;
    void Start()
    {
        yaDesplazado = false;
    }
    void Update()
    {
        if (!yaDesplazado && Input.GetAxis("Jump") > 0)
        {
            transform.position += desplazamiento;
            yaDesplazado = true;
        }
    }
}
