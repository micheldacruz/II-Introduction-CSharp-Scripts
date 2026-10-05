using UnityEngine;

// Ejercicio 13
public class ForwardMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10.0f, Color.red);

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward * speed * Time.deltaTime, Space.World);
        }
    }
}
