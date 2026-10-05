using UnityEngine;

// Ejercicio 8
public class CubeMovement : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f,1.0f,1.0f);
    public float speed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.Self);
    }
}
