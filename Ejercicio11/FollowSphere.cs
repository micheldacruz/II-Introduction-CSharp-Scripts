using UnityEngine;

// Ejercicio 11
public class FollowSphere : MonoBehaviour
{
    public Transform sphereTransform;
    public float speed = 2.0f;
    // Update is called once per frame
    void Update()
    {
        // Si queremos que el cubo pueda modificar su altura
        // transform.Translate((sphereTransform.position - transform.position).normalized * speed * Time.deltaTime, Space.World);

        Vector3 miVector = new Vector3((sphereTransform.position.x - transform.position.x), 
                                        0.0f,
                                       (sphereTransform.position.z - transform.position.z));
        transform.Translate(miVector.normalized * speed * Time.deltaTime, Space.World);
    }
}
