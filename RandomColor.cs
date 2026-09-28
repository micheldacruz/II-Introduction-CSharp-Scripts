using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private Renderer miRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miRenderer = GetComponent<Renderer>();
        miRenderer.material.color = RandomColorVector();
    }

    // Update is called once per frame
    void Update()
    {
        Color colorActual = miRenderer.material.color;
        if (Time.frameCount % 120 == 0) {
            colorActual[Random.Range(0,3)] = Random.value;
        }
        miRenderer.material.color = colorActual;
    }

    // Generate a random color value.
    Color RandomColorVector() {
        return new Color(Random.value, Random.value, Random.value);
    }
}
