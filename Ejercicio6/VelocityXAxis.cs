using UnityEngine;

public class VelocityXAxis : MonoBehaviour
{
    public float velocity = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(
                $"{KeyCode.UpArrow} ha sido pulsado.\n" +
                $"Valor velocidad x eje vertical: {velocity * Input.GetAxis("Vertical")}"
            );
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log(
                $"{KeyCode.DownArrow} ha sido pulsado.\n" +
                $"Valor velocidad x eje vertical: {velocity * Input.GetAxis("Vertical")}"
            );
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(
                $"{KeyCode.LeftArrow} ha sido pulsado.\n" +
                $"Valor velocidad x eje horizontal: {velocity * Input.GetAxis("Horizontal")}"
            );
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log(
                $"{KeyCode.RightArrow} ha sido pulsado.\n" +
                $"Valor velocidad x eje horizontal: {velocity * Input.GetAxis("Horizontal")}"
            );
        }
    }
}
