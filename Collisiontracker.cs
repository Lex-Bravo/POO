//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script retomado del examen bimestral POO
//Descrippcion: Script Score este Script será util para al detectar colsiones el Score aumente.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiontracker : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D Player)

 {
        if (Player.tag == "Player")
        {
            Destroy(gameObject);
        }

 }
}
