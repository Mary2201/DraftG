using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del enemigo
    public float leftBound = -5f; // Límite izquierdo del movimiento
    public float rightBound = 5f; // Límite derecho del movimiento
    private bool movingRight = true; // Dirección actual del movimiento

    void Update()
    {
        // Movimiento horizontal
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // Cambiar dirección al llegar a los límites
        if (transform.position.x >= rightBound)
        {
            movingRight = false;
        }
        else if (transform.position.x <= leftBound)
        {
            movingRight = true;
        }
    }
}
