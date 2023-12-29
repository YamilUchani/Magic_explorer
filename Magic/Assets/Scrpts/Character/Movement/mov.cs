using UnityEngine;

public class mov : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Obtener la entrada del teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Mover el sprite
        transform.position += movement * speed * Time.deltaTime;
    }
}
