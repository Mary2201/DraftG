using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonator : MonoBehaviour
{
    public GameObject Explosion; // Prefab de la explosión
    public float explosionDelay = 5f; // Tiempo en segundos antes de la explosión

    private bool exploded = false;

    void Start()
    {
        // Iniciar la cuenta regresiva para la explosión
        Invoke("Explode", explosionDelay);
    }

    void Explode()
    {
        if (!exploded)
        {
            exploded = true;

            // Desactivar el renderizador de la bomba para que no se vea más
            GetComponent<Renderer>().enabled = false;

            // Reproducir la animación de la explosión
            Instantiate(Explosion, transform.position, transform.rotation);

            // Destruir la bomba después de la explosión
            Destroy(gameObject);
        }
    }
}
