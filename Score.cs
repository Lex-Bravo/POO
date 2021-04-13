//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Examen bimestral POO 
//Descripción: Script que ayudará a sumar al score los puntos

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Puntaje = 20;

    void OnDestroy()
    {
        GameController.Score += Puntaje;

    }
}
