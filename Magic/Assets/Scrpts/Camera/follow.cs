using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform objetivo;
    public float suavidad = 0.3f;
    private Vector2 velocidad = Vector2.zero;

    private void Update()
    {
        if (objetivo == null)
        {
            Debug.LogError("Objetivo no asignado para la cámara.");
            return;
        }

        // Obtener las coordenadas 2D actuales de la cámara y el objetivo
        Vector2 posicionCamara = transform.position;
        Vector2 posicionObjetivo = objetivo.position;

        // Calcular la nueva posición 2D de la cámara utilizando SmoothDamp
        Vector2 nuevaPosicion = Vector2.SmoothDamp(
            posicionCamara,
            posicionObjetivo,
            ref velocidad,
            suavidad);

        // Establecer la nueva posición de la cámara
        transform.position = new Vector3(nuevaPosicion.x, nuevaPosicion.y, transform.position.z);
    }
}
