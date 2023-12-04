using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public float colorChangeSpeed = 1.0f;

    private Material ballMaterial;
    private float hueValue = 0.0f;

    void Start()
    {
        ballMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Continuously change color
        hueValue = (hueValue + colorChangeSpeed * Time.deltaTime) % 1.0f;
        Color newColor = Color.HSVToRGB(hueValue, 1.0f, 1.0f);

        // Apply the new color to the material
        ballMaterial.color = newColor;
    }
}
