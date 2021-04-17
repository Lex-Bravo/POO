//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Examen bimestral POO 
//Descripción: Script en el Player que será útil para poder pasar al trofeo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKey : MonoBehaviour
{

    public GameObject wall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("StarKey"))
        {
            CounterKey.numitem += 1;
            Destroy(collision.gameObject);

            if (CounterKey.numitem == 1)
            {
                wall.SetActive(false);
            }
        }
    }
}
