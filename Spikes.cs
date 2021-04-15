//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script retomado del curso Estructura de Datos 2020 
//Descripción: Script dedicado a la detección de collisión con el personaje y restar vida. A pesar de ser llamado Spikes
//es un script re utilizable para todo aquello que tenga que dañar al jugador.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
