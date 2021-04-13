//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script recicldo proyecto final Estructura de datos
//Descripción: Script hecho para cambio de escenas al registrar colisiones

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio_escena : MonoBehaviour
{
    [Tooltip("esta variable me ayuda a definir el num de escena a cargar")]

    public int numEscena;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(numEscena);
        }
    }
}
